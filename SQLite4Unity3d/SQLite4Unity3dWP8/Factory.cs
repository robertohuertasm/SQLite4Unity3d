using System;
using System.Diagnostics;
using System.IO;
using System.IO.IsolatedStorage;
using System.Threading;
using System.Windows;

namespace SQLite4Unity3d
{
    public class Factory : ISQLiteConnectionFactory
    {
        public ISQLiteConnection Create(string address)
        {
            //let's copy data base from resources to isolatedstorage
            var lastSlashPosition = address.LastIndexOf(@"/", StringComparison.InvariantCulture) + 1;
            var filename = address.Substring(lastSlashPosition, address.Length - lastSlashPosition);
            GetResourceStream(address, src => WriteFile(filename, src.CopyTo));
            return new SQLiteConnection(filename);
        }

        public void GetResourceStream(string resourcePath, Action<Stream> streamAction)
        {
            var streamInfo = Application.GetResourceStream(new Uri(resourcePath, UriKind.Relative));
            streamAction(streamInfo != null
                ? streamInfo.Stream
                : null);
        }

        private static void WriteFile(string path, Action<Stream> streamAction)
        {
            try
            {
                using (var isf = IsolatedStorageFile.GetUserStoreForApplication())
                {
                    using (var fileStream = new IsolatedStorageFileStream(path, FileMode.Create, isf))
                        streamAction(fileStream);
                }
            }
            catch (ThreadAbortException)
            {
                throw;
            }
            catch (Exception exception)
            {
                Debug.WriteLine("Error during file save {0} : {1}", path, exception);
                throw;
            }
        }
    }
}

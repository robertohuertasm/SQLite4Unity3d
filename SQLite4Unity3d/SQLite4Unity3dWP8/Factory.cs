using System;
using System.IO;
using System.IO.IsolatedStorage;
using System.Windows;

namespace SQLite4Unity3d
{
    public class Factory : ISQLiteConnectionFactory
    {
        public ISQLiteConnection Create(string address)
        {
            var lastSlashPosition = address.LastIndexOf(@"/", StringComparison.InvariantCulture) + 1;
            var filename = address.Substring(lastSlashPosition, address.Length - lastSlashPosition);

            //let's check if it exists in our resources
            var streamInfo = Application.GetResourceStream(new Uri(address, UriKind.Relative));
            if (streamInfo == null)
            {
                return new SQLiteConnection(filename);
            }

            //let's copy data base from resources to isolatedstorage
            using (var isf = IsolatedStorageFile.GetUserStoreForApplication())
            {
                if (isf.FileExists(filename))
                {
                    using (var fileStream = 
                        new IsolatedStorageFileStream(filename, FileMode.Create, isf))
                    {
                        streamInfo.Stream.CopyTo(fileStream);
                    }    
                } 
            }
            
            return new SQLiteConnection(filename);
        }
    }
}

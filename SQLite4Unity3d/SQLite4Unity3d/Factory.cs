namespace SQLite4Unity3d
{
    public class Factory : ISQLiteConnectionFactory
    {
        public ISQLiteConnection Create(string address)
        {
            return new SQLiteConnection(address, SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create);
        }
    }
}

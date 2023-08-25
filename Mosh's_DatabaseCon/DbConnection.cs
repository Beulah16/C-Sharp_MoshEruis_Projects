namespace Intermediate
{
    public abstract class DbConnection
    {
        private string ConnectionString;
        public TimeSpan Timeout = new TimeSpan();
        public DbConnection(string ConnectionString)
        {
            if(String.IsNullOrWhiteSpace(ConnectionString))
                throw new InvalidOperationException("Input cannot be null!");
            this.ConnectionString = ConnectionString;
        }
        public abstract void Open();
        public abstract void Close();
    }
}
namespace Intermediate
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection (string ConnectionString)
        :base (ConnectionString)
        {
            Console.WriteLine();
        }
      
        public override void Open()
        {
            Console.WriteLine("\nOpening Connection to Oracle Server...\nConnection to server has been secured");
        }
        public override void Close()
        {
            Console.WriteLine("\nExiting Oracle database... \nConnection Closed!");
        }
    }
}
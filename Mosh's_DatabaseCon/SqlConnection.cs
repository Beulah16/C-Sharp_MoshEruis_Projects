namespace Intermediate
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection (string ConnectionString)
        :base (ConnectionString)
        {
            Console.WriteLine();
        }
        
        public override void Open()
        {
            Console.WriteLine("\nOpening Connection to Sql Server...\nConnection to server has been secured");

        }
        public override void Close()
        {
           Console.WriteLine("\nExiting Sql database... \nConnection Closed!");
        }
    }
}
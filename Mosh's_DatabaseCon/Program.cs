using System;
namespace Intermediate
{
    class UsingDbConnection
    {
        static void Main(string[]args)
        {
            var customise = new Customise();
            Console.WriteLine("Welcome to Database Connection Interface\n\tSQL\tORACLE");
            string choice = Console.ReadLine();
            customise.Check(choice);
            switch(choice.ToLower())
            {
                case "sql":
                var dbCommand1 = new DbCommand(new SqlConnection(customise.RequestString()));
                dbCommand1.Execute();
                break;

                case "oracle":
                var dbCommand2 = new DbCommand(new OracleConnection(customise.RequestString()));
                dbCommand2.Execute();
                break;

                default:
                Console.WriteLine("Invalid Option");
                break;
            }
        }
    }
}
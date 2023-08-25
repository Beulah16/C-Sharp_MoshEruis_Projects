namespace Intermediate
{
    class DbCommand
    {
        private DbConnection server; 
        private string Instruction;
        public  void Check(string input)
        {
            if(String.IsNullOrWhiteSpace(input))
                throw new InvalidOperationException ("Input cannot be empty"); 
        }
        public DbCommand(DbConnection server)
        {
            Check(Convert.ToString(server));
            this.server = server;
            
            System.Console.Write("Enter Instruction: ");
            Instruction = Console.ReadLine();
            Check(Instruction);
        }
        public void Execute()
        {
            server.Open();
            System.Console.WriteLine("\nExecuting Instruction... \n\tDone!");
            server.Close();
        }
    }
}
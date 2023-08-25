namespace Intermediate
{
    class Customise
    {
        public DateTime timein;
        public DateTime timeout;
        public TimeSpan timespan;
        public  void Check(string input)
        {
            if(String.IsNullOrWhiteSpace(input))
            throw new InvalidOperationException ("Input cannot be empty"); 
        }
        public DateTime TimeSpan()
        {
            DateTime timespan = DateTime.Now;
            return timespan;
        }
        public string RequestString()
        {
            Console.Write("Enter connection string: ");
            string connectionstring = Console.ReadLine();
            Check(connectionstring);
            return connectionstring; 
        }
    }
}
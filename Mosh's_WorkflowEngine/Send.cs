namespace Intermediate
{
    public class Send : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Sending an Email to video owner...");
        }
    }
}
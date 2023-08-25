namespace Intermediate
{
    public class Post
    {
        private string Title;
        private string Description;
        
        private int voteCount;
        public DateTime time { get; set; }
        public Post()
        {
            Console.WriteLine("Create a Post");
        }
        public void Check(string option)
        {
            if(String.IsNullOrEmpty(option))
            {
                throw new ArgumentNullException("Input must be valid");
            }
        }
        public void RequestTitle()
        {
            Console.Write("Title =  ");
            string title = Console.ReadLine();
            Check(title);
            Title = title;
        }
        public void Aftermath()
        {
            Console.WriteLine("  View\tDone");
            string choice = Console.ReadLine();
            Check(choice);
            if(choice.ToLower() == "view")
            {
                post();
            }
            else if(choice.ToLower() == "done")
            {
                System.Console.WriteLine($"Vote count:{voteCount}");
            }
            else
            {
                Console.WriteLine("Invalid option");
            }
        }
        public void post()
        {
            Console.WriteLine($"{Title.ToUpper()} \n   {Description} \nVote count:{voteCount} \n\t▲up\t▼down");
            string vote = Console.ReadLine();
            Check(vote.ToString());
            if (vote == "up")
            {
                voteCount++;
            }
            else if (vote == "down")
            {
                voteCount--;
            }
            else
            {
                Console.WriteLine("Invalid option");
            }
            Aftermath();
        }
        
        public void RequestDescription()
        {
            Console.Write("Description =  ");
            string description = Console.ReadLine();
            Check(description);
            Description = description;
            time = DateTime.Now;
            Console.WriteLine("Post created successfully!");
            Aftermath();
        }
       
        
        
    }
}
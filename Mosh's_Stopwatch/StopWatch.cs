namespace Intermediate
{
    public class Stopwatch
    {
        private DateTime start;
        private DateTime stop;   
        private int startCount;
        private int stopCount;   
        public int Validity 
        {
            get 
            {
                return  startCount - stopCount;;
            }
        }
        
        public TimeSpan Duration 
        { 
            get
            {
                return this.stop - this.start;
            }
        }
        public void Check()
        {
            if(Validity != 1)
                            throw new InvalidOperationException ("An error occured");
        }
        public  void  Start()
        {
            this.start = DateTime.Now;
            startCount++;
            Check();
        }
        public  void Stop()
        {
            Check();
            this.stop = DateTime.Now;
            stopCount++; 
            Console.WriteLine($"Time duration: {Duration}");
        }
    }
}
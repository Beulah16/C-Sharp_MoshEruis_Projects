using System.Collections;
namespace Intermediate
{
    public class Stack
    {
        private ArrayList list = new ArrayList();
        
        public void Check(object value)
        {
            if (String.IsNullOrEmpty(value.ToString()))
            throw new InvalidOperationException ("Input is invalid!");
        }
        public void Push(object obj)
        {
            Check(obj);
            list.Add(obj);
        }
        public object Pop()
        {
            if(list.Count == 0)
            throw new InvalidOperationException ("Stack is empty");
            int pos = list.Count - 1;
            object removed = list[pos];
            list.Remove(list[pos]);
            return removed;
        }
        public void Clear()
        {
            list.Clear();
        }
        public void ObjType(Object obj)
        {
            if(obj is int)
            {
                int num = (int)obj;
                Console.WriteLine($"{num} has been removed");
            }
            else if(obj is char)
            {
                char charac = (char) obj;
                Console.WriteLine($"{charac} has been removed");
            }
            else
            {
                string msg = (string) obj;
                Console.WriteLine($"{msg} has been removed");
            }
        }
    }
}
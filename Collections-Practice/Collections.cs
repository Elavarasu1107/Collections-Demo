using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Practice
{
    public class Collections
    {
        public void Queue()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Elavarasu");
            queue.Enqueue("Nandha");
            queue.Enqueue("Senthil");
            queue.Enqueue("Kodi");
            queue.Enqueue("Jaya");

            Console.WriteLine("Data available in Queue:");
            foreach (string item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nHead: "+queue.Peek());
            string deQueue = queue.Dequeue();
            Console.WriteLine("\nDequeue First Element:" + deQueue);
            Console.WriteLine("\nData available in Queue after removing one Element:");

            Queue<string>.Enumerator enumerator = queue.GetEnumerator();
            while(enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
        public void Set()
        {
            var set = new HashSet<string>();
            set.Add("Elavarasu");
            set.Add("Nandha");
            set.Add("Senthil");
            set.Add("Kodi");
            set.Add("Jaya");

            HashSet<string>.Enumerator enumerator = set.GetEnumerator();
            Console.WriteLine("Data available in Hashset:");
            while(enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
        public void Dictionary()
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "Elavarasu");
            dictionary.Add(2, "Nandha");
            dictionary.Add(3, "Senthil");
            dictionary.Add(4, "Kodi");
            dictionary.Add(5, "Jaya");
            Console.WriteLine("Accessing Data using Key: " + dictionary[1]);
            Console.WriteLine("Data available in Dictionary: ");
            foreach(KeyValuePair<int, string> kvp in dictionary)
            {
                Console.WriteLine("Key: " + kvp.Key + "\tValue: " + kvp.Value);
            }
        }
        public void List()
        {
            List<string> list = new List<string>();
            list.Add("Elavarasu");
            list.Add("Nandha");
            list.Add("Senthil");
            list.Add("Kodi");
            list.Add("Jaya");
            Console.WriteLine("Data available in List:");
            foreach(string item in list)
            {
                Console.WriteLine(item);
            }
        }
        public void Stack()
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("Elavarasu");
            stack.Push("Nandha");
            stack.Push("Senthil");
            stack.Push("Kodi");
            stack.Push("Jaya");

            Console.WriteLine("Last Data in the Stack: " + stack.Peek());
            string pop = stack.Pop();
            Console.WriteLine("Data " + pop + " Poped from Stack");
            Console.WriteLine("Data availabe after Poping one element from Stack: ");
            foreach(string item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}

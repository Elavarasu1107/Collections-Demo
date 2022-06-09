using System;

namespace Collections_Practice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Collections getMethod = new Collections();
            getMethod.Queue();
            Console.WriteLine("-------------------------------------------------");
            getMethod.Set();
            Console.WriteLine("-------------------------------------------------");
            getMethod.Dictionary();
            Console.WriteLine("-------------------------------------------------");
            getMethod.List();
            Console.WriteLine("-------------------------------------------------");
            getMethod.Stack();
            Console.WriteLine("-------------------------------------------------");
        }
    }
}

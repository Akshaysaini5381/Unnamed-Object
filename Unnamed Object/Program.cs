using System;

namespace Unnamed_Object
{
    class C1
    {
        public void show()
        {
            Console.WriteLine("hello :");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            new C1().show();
            new C1().show();
        }
    }
}

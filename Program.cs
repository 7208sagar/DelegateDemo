using System;

namespace DelegateDemo
{
    class Program

    {
        public delegate void MyDelegates(int a, int b);
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            MyDelegates del = new MyDelegates(Add);
            del(2, 4);

        }
        public static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
    }
}


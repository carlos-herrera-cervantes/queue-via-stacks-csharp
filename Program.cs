using System;
using QueueWithStackConsoleApp.Models;

namespace QueueWithStackConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new MyQueue<string>();
            Console.WriteLine(queue.GetSize());
        }
    }
}

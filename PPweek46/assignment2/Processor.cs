using System;

namespace assignment2
{
    public class Processor : IProcessor
    {
        public string Task { get; }

        public Processor(string task)
        {
            Task = task;
        }

        public void PerformOperation()
        {
            Console.WriteLine(Task);
        }
    }
}
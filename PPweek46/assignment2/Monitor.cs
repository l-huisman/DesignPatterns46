using System;

namespace assignment2
{
    public class Monitor : IMonitor
    {
        public string Task { get; }

        public Monitor(string task)
        {
            Task = task;
        }

        public void Display()
        {
            Console.WriteLine(Task);
        }
    }
}

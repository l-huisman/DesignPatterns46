using System;

namespace assignment2
{
    public class HardDisk : IHardDisk
    {
        public string Task { get; }

        public HardDisk(string task)
        {
            Task = task;
        }

        public void StoreData()
        {
            Console.WriteLine(Task);
        }
    }
}
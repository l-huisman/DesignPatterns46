namespace assignment2
{
    public class Computer
    {
        public IProcessor Processor { get; set; }
        public IHardDisk HardDisk { get; set; }
        public IMonitor Monitor { get; set; }

        public Computer()
        {

        }

        public void Test()
        {
            Processor.PerformOperation();
            HardDisk.StoreData();
            Monitor.Display();
        }
    }
}
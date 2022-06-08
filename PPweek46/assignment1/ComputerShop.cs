namespace assignment1
{
    public abstract class ComputerShop
    {
        public Computer AssembleComputer()
        {
            Computer computer = new Computer();
            computer.Processor = CreateProcessor();
            computer.HardDisk = CreateHardDisk();
            computer.Monitor = CreateMonitor();

            return computer;
        }

        public abstract IProcessor CreateProcessor();
        public abstract IHardDisk CreateHardDisk();
        public abstract IMonitor CreateMonitor();

        public void TestComputer(Computer computer) 
        {
            computer.Processor.PerformOperation();
            computer.HardDisk.StoreData();
            computer.Monitor.Display();
        }
    }
}
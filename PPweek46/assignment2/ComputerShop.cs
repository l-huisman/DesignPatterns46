namespace assignment2
{
    public class ComputerShop
    {
        private ComputerFactory computerFactory;
        public ComputerShop(ComputerFactory computerFactory)
        {
            this.computerFactory = computerFactory;
        }
        public Computer AssembleComputer()
        {
            Computer computer = new Computer();
            computer.Processor = computerFactory.CreateProcessor();
            computer.Monitor = computerFactory.CreateMonitor();
            computer.HardDisk = computerFactory.CreateHardDisk();

            return computer;
        }
    }
}
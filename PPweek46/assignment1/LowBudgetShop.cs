namespace assignment1
{
    public class LowBudgetShop : ComputerShop
    {
        public override IHardDisk CreateHardDisk()
        {
            return new HardDisk("storing data not so quickly...");
        }

        public override IMonitor CreateMonitor()
        {
            return new Monitor("displaying stuff very poor...");
        }

        public override IProcessor CreateProcessor()
        {
            return new Processor("performing operation not so quickly...");
        }
    }
}
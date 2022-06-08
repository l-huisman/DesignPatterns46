namespace assignment1
{
    public class HighBudgetShop : ComputerShop
    {
        public override IHardDisk CreateHardDisk()
        {
            return new HardDisk("storing data very quickly...");
        }

        public override IMonitor CreateMonitor()
        {
            return new Monitor("displaying stuff very nice...");
        }

        public override IProcessor CreateProcessor()
        {
            return new Processor("performing operation very quickly...");
        }
    }
}
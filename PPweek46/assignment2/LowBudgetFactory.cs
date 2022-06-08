namespace assignment2
{
    public class LowBudgetFactory : ComputerFactory
    {
        public override IProcessor CreateProcessor()
        {
            return new LowBudgetProcessor("performing operation very quickly...");
        }

        public override IHardDisk CreateHardDisk()
        {
            return new LowBudgetHardDisk("storing data not so quickly...");
        }

        public override IMonitor CreateMonitor()
        {
            return new LowBudgetMonitor("displaying stuff very poor...");
        }
    }
}


namespace assignment2
{
    public class HighBudgetFactory : ComputerFactory
    {
        public override IProcessor CreateProcessor()
        {
            return new HighBudgetProcessor("performing operation very quickly...");
        }

        public override IHardDisk CreateHardDisk()
        {
            return new HighBudgetHardDisk("storing data very quickly...");
        }

        public override IMonitor CreateMonitor()
        {
            return new HighBudgetMonitor("displaying stuff very nice...");
        }
    }
}


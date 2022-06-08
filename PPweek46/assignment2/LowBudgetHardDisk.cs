namespace assignment2
{
    public class LowBudgetHardDisk : IHardDisk
    {
        private string message;

        public LowBudgetHardDisk(string message)
        {
            this.message = message;
        }

        public void StoreData()
        {
            Console.WriteLine(message);
        }
    }
}
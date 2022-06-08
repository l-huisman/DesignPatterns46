namespace assignment2
{
    public class HighBudgetHardDisk : IHardDisk
    {
        private string message;

        public HighBudgetHardDisk(string message)
        {
            this.message = message;
        }

        public void StoreData()
        {
            Console.WriteLine(message);
        }
    }
}
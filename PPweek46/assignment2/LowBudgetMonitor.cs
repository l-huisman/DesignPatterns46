namespace assignment2
{
    public class LowBudgetMonitor : IMonitor
    {
        private string message;

        public LowBudgetMonitor(string message)
        {
            this.message = message;
        }

        public void Display()
        {
            Console.WriteLine(message);
        }
    }
}
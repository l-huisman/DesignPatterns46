namespace assignment2
{
    public class HighBudgetMonitor : IMonitor
    {
        private string message;

        public HighBudgetMonitor(string message)
        {
            this.message = message;
        }

        public void Display()
        {
            Console.WriteLine(message);
        }
    }
}
namespace assignment2
{
    public class HighBudgetProcessor : IProcessor
    {
        private string message;

        public HighBudgetProcessor(string message)
        {
            this.message = message;
        }

        public void PerformOperation()
        {
            Console.WriteLine(message);
        }
    }
}
namespace assignment2
{
    public class LowBudgetProcessor : IProcessor
    {
        private string message;

        public LowBudgetProcessor(string message)
        {
            this.message = message;
        }

        public void PerformOperation()
        {
            Console.WriteLine(message);
        }
    }
}
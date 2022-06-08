using System;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }

        void Start()
        {
            // create a shop where they assemble expensive computers
            Console.WriteLine("[shop creating expensive computers]");
            HighBudgetShop highEndShop = new HighBudgetShop();
            Computer highEndComputer = highEndShop.AssembleComputer();
            highEndShop.TestComputer(highEndComputer);
            
            Console.WriteLine();

            // create a shop where they assemble cheap computers
            Console.WriteLine("[shop creating cheap computers]");
            LowBudgetShop lowEndShop = new LowBudgetShop();
            Computer lowEndComputer = lowEndShop.AssembleComputer();
            lowEndShop.TestComputer(lowEndComputer);
        }
    }
}
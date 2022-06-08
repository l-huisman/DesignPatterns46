using System;

namespace assignment2
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

            ComputerFactory highBudgetFactory = new HighBudgetFactory();
            ComputerShop computerShop = new ComputerShop(highBudgetFactory);
            Computer highendcomputer = computerShop.AssembleComputer();
            Console.WriteLine("[shop creating expensive computers]");
            highendcomputer.Test();

            Console.WriteLine();

            ComputerFactory lowBudgetFactory = new LowBudgetFactory();
            computerShop = new ComputerShop(lowBudgetFactory);
            Computer lowendcomputer = computerShop.AssembleComputer();
            Console.WriteLine("[shop creating cheap computers]");
            lowendcomputer.Test();
        }
    }
}
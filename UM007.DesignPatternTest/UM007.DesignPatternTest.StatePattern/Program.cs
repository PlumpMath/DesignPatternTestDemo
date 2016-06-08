using System;

namespace UM007.DesignPatternTest.StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            GumballMachine gumballMachine = new GumballMachine();
            gumballMachine.SetCount(6);
            while (true)
            {
                Console.Write("是否继续(y/n):");
                if (!System.Console.ReadLine().ToUpper().Trim().Equals("Y")) return;
                gumballMachine.InsertQuarter();
                gumballMachine.TurnCrank();
            }
        }
    }
}

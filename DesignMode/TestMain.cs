using System;
using DesignMode.Creational.FactoryPattern;
using DesignMode.Creational.StrategyPattern;

namespace DesignMode
{
    internal class TestMain
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("执行Main");
            Console.WriteLine( "-----------------------工厂模式--------------------------------");
            IFactory factory = new Operation().OperationSymbol("+");
            factory._numberA = 10;
            factory._numberB = 20;
            Console.WriteLine( factory.GetResult());
            Console.WriteLine( "-----------------------策略模式--------------------------------");
            CashContext cashContext=new CashContext("打8折");
            Console.WriteLine( cashContext.GetResult(1000));
        }
    }
}
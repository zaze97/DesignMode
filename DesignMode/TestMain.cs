using System;
using DesignMode.Creational.FactoryPattern;

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

        }
    }
}
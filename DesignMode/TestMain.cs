using System;
using DesignMode.Creational.DecorativePattern;
using DesignMode.Creational.FactoryPattern;
using DesignMode.Creational.ProxyPattern;
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
            Console.WriteLine( "-----------------------装饰模式--------------------------------");
            Person ps=new Person("超人");
            Console.WriteLine("开始装饰");
            TShorts ts=new TShorts();
            Trouser tr=new Trouser();       
            ts.Decorate(ps);
            tr.Decorate(ts);
            tr.Show();
            Console.WriteLine( "-----------------------代理模式--------------------------------");
            GivePeople  people=new GivePeople("小孩");
            Proxy proxy=new Proxy(people);
            proxy.GiveWater();
            proxy.GiveEat();
            proxy.GivePlay();
        }
    }
}
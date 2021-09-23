using System;
///工厂模式
namespace DesignMode.Creational.FactoryPattern
{
    
    public interface IFactory
    {
        double _numberA { get; set; }
        double _numberB { get; set; }
        double GetResult();
    }

    abstract class Factory : IFactory
    {
        public double _numberA { get; set; }
        public double _numberB { get; set; }
        public abstract double GetResult();
    }

    class FactoryAdd : Factory, IFactory
    {
        public override double GetResult()
        {
            return _numberA + _numberB;
        }
    }

    class FactorySub : Factory, IFactory
    {
        public override double GetResult()
        {
            return _numberA - _numberB;
        }
    }

    class FactoryMul : Factory, IFactory
    {
        public override double GetResult()
        {
            return _numberA * _numberB;
        }
    }

    class FactoryDiv : Factory, IFactory
    {
        public override double GetResult()
        {
            return _numberA / _numberB;
        }
    }

    class  Operation
    {
        public IFactory OperationSymbol(string symbol)
        {
            switch (symbol)
            {
                case "+":
                    return new FactoryAdd();
                    break;
                case "-":
                    return new FactorySub();
                    break;
                case "*":
                    return new FactoryMul();
                    break;
                case "/":
                    return new FactoryDiv();
                    break;
                default:
                    Console.WriteLine("没有此运算");
                    return null;
                    break;
            }
        }
    }

}
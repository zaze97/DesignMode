using System;
//策略模式
namespace DesignMode.Creational.StrategyPattern
{
        //策略基类
        abstract class CashSuper
        {
            public abstract double acceptCash(double money);
        }

        class CashNormal: CashSuper
        {
            public override double acceptCash(double money)
            {
                return money;
            }
        }

        class  CashRebate: CashSuper
        {
            private double moneyRebate = 1;

            public CashRebate(string moneyrebate)
            {
                this.moneyRebate =double.Parse(moneyrebate);
            }
            public override double acceptCash(double money)
            {
                return money * moneyRebate;
            }
        }
        class CashReturn : CashSuper
        {
            private double moneyCondition = 0;
            private double moneyReturn = 0;

            public CashReturn(string moneyCondition, string moneyReturn)
            {
                this.moneyCondition = double.Parse(moneyCondition);
                this.moneyReturn = double.Parse(moneyReturn);
            }
            public override double acceptCash(double money)
            {
                double result = money;
                if (money >= moneyCondition)
                {
                    result = money - Math.Floor(money / moneyCondition) * moneyReturn;
                }

                return result;
            }
        }
        //算法实现类(与客户端分离)
        class CashContext
        {
            private CashSuper cs;

            public CashContext(string type)
            {
                switch (type)
                {
                    case "正常收费":
                        cs=new CashNormal(); 
                        break;
                    case "300返100":
                        cs=new CashReturn("300","100");
                        break;
                    case "打8折":
                        cs=new CashRebate("0.8");
                        break;
                }
            }

            public double GetResult(double money)
            {
                return cs.acceptCash(money);
            }
        }
}
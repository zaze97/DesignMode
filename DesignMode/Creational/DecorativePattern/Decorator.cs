using System;
//装饰模式
namespace DesignMode.Creational.DecorativePattern
{
    public class Person
    {
        private string name;
        public Person(){}
        public Person(string name)
        {
            this.name = name;
        }

        public virtual void Show()
        {
            Console.WriteLine("装扮的{0}",name);
        }
    }
    public class Finery:Person
    {
        protected Person component;
        
        //打扮
        public void Decorate(Person component)
        {
            this.component = component;
        }

        public override void Show()
        {
            if(component!=null)
                component.Show();
        }
    }
    class TShorts:Finery
    {
        public override void Show()
        {
            Console.Write("大体恤");
            base.Show();
        }
    }
    class Trouser:Finery
    {
        public override void Show()
        {
            Console.Write("大裤子");
            base.Show();
        }
    }
}
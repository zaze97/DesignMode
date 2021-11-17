using System;

namespace DesignMode.Creational.ProxyPattern
{
    public interface IGiveGift
    {
        void GiveWater();
        void GiveEat();
        void GivePlay();
    }
    
    
    //需求类:
    class Pursult : IGiveGift
    {
        GivePeople GiveName;

        public Pursult(GivePeople name)
        {
            this.GiveName = name;
        }
        public void GiveWater()
        {
            Console.WriteLine("送给" + GiveName.Name + "水");
        }

        public void GiveEat()
        {
            Console.WriteLine("送给" + GiveName.Name + "吃的");
        }

        public void GivePlay()
        {
            Console.WriteLine( "送给"+ GiveName.Name+"玩的");
        }
    }
    
    //代理类：
    class Proxy:IGiveGift
        {
            IGiveGift gg;

            public Proxy(GivePeople mm)
            {
                gg = new Pursult(mm);
            }

            public void GiveWater()
            {
                gg.GiveWater();
            }

            public void GiveEat()
            {
                gg.GiveEat();
            }

            public void GivePlay()
            {
                gg.GivePlay();
            }
        }
    //被需求类：
    class GivePeople
        {
            public GivePeople(string name)
            {
                Name = name;
            }


            private string name;
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
        }
}
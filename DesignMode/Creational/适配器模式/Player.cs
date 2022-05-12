//基类

using System;

public abstract class Player
{
    protected string name;

    public Player(string name)
    {
        this.name = name;
    }

    public abstract void Attack();
    public abstract void Defense();
}

class Forwaeds : Player
{
    public Forwaeds(string name) : base(name)
    {
    }

    public override void Attack()
    {
        Console.WriteLine("前锋{0}进攻", name);
    }

    public override void Defense()
    {
        Console.WriteLine("前锋{0}防守", name);
    }
}

class Center : Player
{
    public Center(string name) : base(name)
    {
    }

    public override void Attack()
    {
        Console.WriteLine("中锋{0}进攻", name);
    }

    public override void Defense()
    {
        Console.WriteLine("中锋{0}防守", name);
    }
}

class Guards : Player
{
    public Guards(string name) : base(name)
    {
    }

    public override void Attack()
    {
        Console.WriteLine("后卫{0}进攻", name);
    }

    public override void Defense()
    {
        Console.WriteLine("后卫{0}防守", name);
    }
}

//外籍中锋
class OutCenter
{
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public void 进攻()
    {
        Console.WriteLine("外籍中锋{0}进攻", name);
    }

    public void 防守()
    {
        Console.WriteLine("外籍中锋{0}防守", name);
    }
}
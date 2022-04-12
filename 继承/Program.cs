global using global::Newtonsoft.Json.Linq;

/*继承是面向对象程序设计中最重要的概念之一。
 * 继承允许我们根据一个类来定义另一个类，这使得创建和维护应用程序变得更容易。同时也有利于重用代码和节省开发时间。
 * 当创建一个类时，程序员不需要完全重新编写新的数据成员和成员函数，只需要设计一个新的类，继承了已有的类的成员即可。
 * 这个已有的类被称为的基类，这个新的类被称为派生类。*/
{
    //长方体体积 rectangle = new 长方体体积(10);
    //rectangle.Width = 10;
    //rectangle.Height = 10;
    //rectangle.GetArea();
    //rectangle.Display_vir();
    //rectangle.Didplay_Abs();

    ParentClass par = new ChildClass1();
    par.ParVirMethod(); //结果："子类1的方法"，调用子类的方法，实现了多态

    par = new ChildClass2();
    par.ParVirMethod(); //结果："父类的方法"，调用父类的方法，没有实现多态  
}

#region 继承基本，基类有参构造，抽象，虚拟
abstract class Shape
{

    public Shape(int a)
    {
        Console.WriteLine($"基类构造:{a}");
    }
    public virtual int Width { get; set; }
    public virtual int Height { get; set; }

    public virtual void Display_vir()
    {
        Console.WriteLine($"基类Display");
    }
    public abstract void Didplay_Abs();


}

class Rectangle : Shape
{
    public Rectangle(int a) : base(a)
    {
        Console.WriteLine($"子类构造{a}");
    }
    public override void Didplay_Abs()
    {
        Console.WriteLine("Rectangle:Didplay_Abs");
    }


    public override void Display_vir()
    {
        Console.WriteLine($"子类Display");
    }
    public int GetArea()
    {
        JObject a;
        Console.WriteLine(Width * Height);
        return Width * Height;
    }
}

class 长方体体积 : Rectangle
{
    public 长方体体积(int a) : base(a)
    {
        Console.WriteLine($"长方体体积{a}");
    }
    public override void Display_vir()
    {
        Console.WriteLine("长方体体积");
    }
    public override void Didplay_Abs()
    {
        base.Didplay_Abs();
        Console.WriteLine();
    }

}
#endregion

/// <summary>  
/// 父类  
/// </summary>  
public class ParentClass
{
    public virtual void ParVirMethod()
    {
        Console.WriteLine("父类的方法...");
    }
}

/// <summary>  
/// 子类1  
/// </summary>  
public class ChildClass1 : ParentClass
{
    public override void ParVirMethod()
    {
        Console.WriteLine("子类1的方法...");
    }
}

/// <summary>  
/// 子类2  
/// </summary>  
public class ChildClass2 : ParentClass
{
    public new void ParVirMethod()
    {
        Console.WriteLine("子类2的方法...");
    }

    public void Test()
    {
        Console.WriteLine("子类2的其他方法...");
    }
}



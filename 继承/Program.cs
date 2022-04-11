global using global::Newtonsoft.Json.Linq;


{
    /*
     * C#不支持多继承，如果想实现需要通过接口。
     * 
     * 
     */
    长方体体积 rectangle = new 长方体体积(10);
    rectangle.Width = 10;
    rectangle.Height = 10;
    rectangle.GetArea();
    rectangle.Display_vir();
    rectangle.Didplay_Abs();
}


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
    public 长方体体积(int a):base(a)
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
    }

}

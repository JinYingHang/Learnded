#define PI
{
    //多态分为：
    //静态多态，
    //动态多态
    People p = new Person();
    p.Display();
    p = new Women();
    p.Display();

    Box box = new Box() { width=10,hight=12};
    Circle circle = new Circle() { width = 10, hight = 12 };
    var boxPlus= box+circle;
    Console.WriteLine($"boxPlus-Width:{boxPlus.width}Height:{boxPlus.hight}");
}
#region 方法的重载--静态多态
public class Calc
{
    public void Add(int a, int b)
    {
        Console.WriteLine(a + b);
    }
    public void Add(int a, int b, int c)
    {
        Console.WriteLine(a + b + c);
    }
}
#endregion
#region 运算符的重载--静态多态

class Box
{
    public int width { get; set; }
    public int hight { get; set; }
    public static Box operator +(Box box1, Circle circle)
    {
        Box box = new Box();
        box.width = circle.width+box1.width;
        box.hight = circle.hight+box1.hight;
        return box;
    }
}
class Circle
{
    public int width { get; set; }
    public int hight { get; set; }
}

 


#endregion
#region 抽象继承--动态多态

public abstract class People
{
    private int _id;
    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }
    public abstract void Display();
}
public class Person : People
{
    public override void Display()
    {
        Console.WriteLine(Id);
    }
}
public class Women : People
{
    public override void Display()
    {
        Console.WriteLine("women");
    }
}

#endregion



namespace PreprocessorDAppl
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "aaa";
            string b = "bbb";
            a.Any(x => x.Equals(b));
#if PI
            Console.WriteLine("PI is defined");
#else
            Console.WriteLine("PI is not defined");
#endif
            Console.ReadKey();
        }
    }
}
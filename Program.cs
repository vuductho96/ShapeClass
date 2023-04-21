using ShapeClass;
using System ;

namespace ShapeClass
{
    public class Shape {
        public string Color { get; set; }
        public bool Filled { get; set; }
        public Shape()
        {
              Color = "Green";
             Filled = true;
        }
public virtual string Tostring() {
            return $"A Shape with color of {Color} and filled {(Filled ? "filled" : "not filled")}";
        }
}
    public class Circle : Shape {
        public double Radius; 
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double Getarea()
        {
            return Math.PI * Radius * Radius;
        }
        public  double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
        public override string ToString()
        {
            return $"A Circle with radius={Radius}, which is a subclass of {base.ToString()}";
        }
    }

}
public class Rectagular : Shape
{

    public double Width { get; set; }
   public double Length { get; set; }
    public Rectagular(double width, double length)
    {
        this.Width = width;
        this.Length = length;
    }
    public  double Getarea()
    {
        return Width * Length;
    }
    public double GetPerimeter()
    {
        return 2 * (Width + Length);

    }
    public override string ToString()
    {
        return $"A Rectangle with width={Width} and length={Length}, which is a subclass of {base.ToString()}";
    }   

}
public class Square : Rectagular
{
    public Square(double side) : base(side, side)
    {
    }

    public override string ToString()
    {
        return $"A Square with side={Width}, which is a subclass of {base.ToString()}";
    }
}

public class Program
    {
       
        static void Main(string[] args)
        {
        Shape shape = new Shape();
        Console.WriteLine(shape.ToString());
        Console.WriteLine("===================================");
        Circle circle = new Circle(5);
        Console.WriteLine(circle.ToString());
        Console.WriteLine($"Area={circle.Getarea()}, Perimeter={circle.GetPerimeter()}");
        Console.WriteLine($"Area={circle.Getarea()}, Perimeter={circle.GetPerimeter()}");

        Console.WriteLine("===================================");
        Rectagular rectangle = new Rectagular(3, 4);
        Console.WriteLine(rectangle.ToString());

        Square square = new Square(5);
        Console.WriteLine(square.ToString());
        Console.WriteLine($"Area={square.Getarea()}, Perimeter={square.GetPerimeter()}");

    }
    }

        
    


// See https://aka.ms/new-console-template for more information

using System;

namespace Shapes
{
    public interface Shape
    {
        public string whoAmI();
    }

    public class Two_dimensional : Shape
    {
        public virtual double Area(double radius_or_length)
        {
            return -1;
        }

        public virtual double Area(double length, double width)
        {
            return -1;
        }

        public virtual double Area(double side_a, double side_b, double side_c)
        {
            return -1;
        }

        public virtual double Perimeter(double radius_or_length)
        {
            return -2;
        }

        public virtual double Perimeter(double length, double width)
        {
            return -2;
        }

        public virtual double Perimeter(double side_a, double side_b, double side_c)
        {
            return -2;
        }

        public string whoAmI()
        {
            return "";
        }
    }

    public class Three_dimensional : Shape
    {
        public virtual double SurfaceArea(double radius_or_length)
        {
            return -3;
        }

        public virtual double Volume(double radius_or_length)
        {
            return -4;
        }

        public virtual double SurfaceArea(double radius, double height)
        {
            return -3;
        }

        public virtual double Volume(double radius, double height)
        {
            return -4;
        }

        public string whoAmI()
        {
            return "";
        }
    }

    public class Circle : Two_dimensional
    {
        public double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double Area(double radius)
        {
            return (3.1416 * radius * radius);
        }

        public override double Perimeter(double radius)
        {
            return (2 * 3.1416 * radius);
        }

        public string whoAmI()
        {
            return "I am Circle. I am a two-dimensional shape.";
        }
    }

    public class Square : Two_dimensional
    {
        public double length;

        public Square(double length)
        {
            this.length = length;
        }

        public override double Area(double length)
        {
            return (length * length);
        }

        public override double Perimeter(double length)
        {
            return (4 * length);
        }

        public string whoAmI()
        {
            return "I am Square. I am a two-dimensional shape.";
        }
    }

    public class Rectangle : Two_dimensional
    {
        public double length;
        public double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public override double Area(double length, double width)
        {
            return (length * width);
        }

        public override double Perimeter(double length, double width)
        {
            return (2 * (length + width));
        }

        public string whoAmI()
        {
            return "I am Rectangle. I am a two-dimensional shape.";
        }
    }

    public class Triangle : Two_dimensional
    {
        public double side_a;
        public double side_b;
        public double side_c;

        public Triangle(double side_a, double side_b, double side_c)
        {
            this.side_a = side_a;
            this.side_b = side_b;
            this.side_c = side_c;
        }

        public override double Area(double side_a, double side_b, double side_c)
        {
            double s;

            s = (side_a + side_b + side_c) / 2;

            return Math.Sqrt(s * (s - side_a) * (s - side_b) * (s - side_c));
        }

        public override double Perimeter(double side_a, double side_b, double side_c)
        {
            return (side_a + side_b + side_c);
        }

        public string whoAmI()
        {
            return "I am Triangle. I am a two-dimensional shape.";
        }
    }

    public class Sphere: Three_dimensional
    {
        public double radius;

        public Sphere(double radius)
        {
            this.radius = radius;
        }

        public override double SurfaceArea(double radius)
        {
            return (4 * 3.1416 * radius * radius);
        }

        public override double Volume(double radius)
        {
            return (1.33 * 3.1416 * radius * radius * radius);
        }

        public string whoAmI()
        {
            return "I am Sphere. I am a three-dimensional shape.";
        }
    }

    public class Cube : Three_dimensional
    {
        public double length;

        public Cube(double length)
        {
            this.length = length;
        }

        public override double SurfaceArea(double length)
        {
            return (6 * length * length);
        }

        public override double Volume(double length)
        {
            return (length * length * length);
        }

        public string whoAmI()
        {
            return "I am Cube. I am a three-dimensional shape.";
        }
    }

    public class Cylinder : Three_dimensional
    {
        public double radius;
        public double height;

        public Cylinder(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
        }

        public override double SurfaceArea(double radius, double height)
        {
            return (2 * 3.1416 * radius * (radius + height));
        }

        public override double Volume(double radius, double height)
        {
            return (3.1416 * radius * radius * height);
        }

        public string whoAmI()
        {
            return "I am Cylinder. I am a three-dimensional shape.";
        }
    }

    public class Cone : Three_dimensional
    {
        public double radius;
        public double height;

        public Cone(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
        }

        public override double SurfaceArea(double radius, double height)
        {
            double l;

            l = Math.Sqrt((radius * radius) + (height * height));

            return (3.1416 * radius * (radius + l));
        }

        public override double Volume(double radius, double height)
        {
            return (0.333 * 3.1416 * radius * radius * height);
        }

        public string whoAmI()
        {
            return "I am Cone. I am a three-dimensional shape.";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Circle

            Console.WriteLine("Enter circle radius: ");

            double radius = Convert.ToDouble(Console.ReadLine());

            Circle dummy_circle = new Circle(radius);

            Console.WriteLine("Area: " + Convert.ToString(dummy_circle.Area(radius)));
            Console.WriteLine("Perimeter: " + Convert.ToString(dummy_circle.Perimeter(radius)));

            Console.WriteLine(dummy_circle.whoAmI() + "\n..........................................");
            Console.ReadKey();

            //Square

            Console.WriteLine("Enter length of side of square: ");

            double length = Convert.ToDouble(Console.ReadLine());

            Square dummy_square = new Square(length);

            Console.WriteLine("Area: " + Convert.ToString(dummy_square.Area(length)));
            Console.WriteLine("Perimeter: " + Convert.ToString(dummy_square.Perimeter(length)));

            Console.WriteLine(dummy_square.whoAmI() + "\n..........................................");
            Console.ReadKey();

            //Rectangle

            Console.WriteLine("Enter length of rectangle: ");

            double length2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter width of rectangle: ");

            double width = Convert.ToDouble(Console.ReadLine());

            Rectangle dummy_rec = new Rectangle(length2, width);

            Console.WriteLine("Area: " + Convert.ToString(dummy_rec.Area(length2, width)));
            Console.WriteLine("Perimeter: " + Convert.ToString(dummy_rec.Perimeter(length2, width)));

            Console.WriteLine(dummy_rec.whoAmI() + "\n..........................................");
            Console.ReadKey();

            //Triangle

            Console.WriteLine("Enter first side of triangle: ");

            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second side of triangle: ");

            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter third side of triangle: ");

            double c = Convert.ToDouble(Console.ReadLine());

            Triangle dummy_tri = new Triangle(a, b, c);

            Console.WriteLine("Area: " + Convert.ToString(dummy_tri.Area(a, b, c)));
            Console.WriteLine("Perimeter: " + Convert.ToString(dummy_tri.Perimeter(a, b, c)));

            Console.WriteLine(dummy_tri.whoAmI() + "\n..........................................");
            Console.ReadKey();

            //Sphere

            Console.WriteLine("Enter sphere radius: ");

            double radius2 = Convert.ToDouble(Console.ReadLine());

            Sphere dummy_sphere = new Sphere(radius2);

            Console.WriteLine("Surface Area: " + Convert.ToString(dummy_sphere.SurfaceArea(radius2)));
            Console.WriteLine("Volume: " + Convert.ToString(dummy_sphere.Volume(radius2)));

            Console.WriteLine(dummy_sphere.whoAmI() + "\n..........................................");
            Console.ReadKey();

            //Cube

            Console.WriteLine("Enter length of side of cube: ");

            double length3 = Convert.ToDouble(Console.ReadLine());

            Cube dummy_cube = new Cube(length3);

            Console.WriteLine("Surface Area: " + Convert.ToString(dummy_cube.SurfaceArea(length3)));
            Console.WriteLine("Volume: " + Convert.ToString(dummy_cube.Volume(length3)));

            Console.WriteLine(dummy_cube.whoAmI() + "\n..........................................");
            Console.ReadKey();

            //Cylinder

            Console.WriteLine("Enter radius of cylinder: ");

            double radius3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter height of cylinder: ");

            double height = Convert.ToDouble(Console.ReadLine());

            Cylinder dummy_cyl = new Cylinder(radius3, height);

            Console.WriteLine("Surface Area: " + Convert.ToString(dummy_cyl.SurfaceArea(radius3, height)));
            Console.WriteLine("Volume: " + Convert.ToString(dummy_cyl.Volume(radius3, height)));

            Console.WriteLine(dummy_cyl.whoAmI() + "\n..........................................");
            Console.ReadKey();

            //Cone

            Console.WriteLine("Enter radius of cone: ");

            double radius4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter height of cone: ");

            double height2 = Convert.ToDouble(Console.ReadLine());

            Cone dummy_cone = new Cone(radius4, height2);

            Console.WriteLine("Surface Area: " + Convert.ToString(dummy_cone.SurfaceArea(radius4, height2)));
            Console.WriteLine("Volume: " + Convert.ToString(dummy_cone.Volume(radius4, height2)));

            Console.WriteLine(dummy_cone.whoAmI() + "\n..........................................");
            Console.ReadKey();
        }
    }
}


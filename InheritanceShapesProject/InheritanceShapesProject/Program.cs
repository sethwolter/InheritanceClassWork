using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceShapesProject
{
    /*this is the base class for our "shapes"
           so we will give it a height and width */
    abstract class Shape
    {
        public abstract double Area //overriding a method or variable----abstract keyword
        {
            get;
        }

        public Shape()
        {
            Height = 0;
            Width = 0;
            Radius = 0;
            Apothem = 0;
            Base1 = 0;
            Perimeter = 0;
        }

        string[] ShapeType = new string[6] { "SQUARE", "RECTANGLE", "CIRCLE", "TRIANGLE", "DIAMOND", "HEXAGON" };

        private double height;
        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        private double width;
        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        private double radius;
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        private double apothem;
        public double Apothem
        {
            get { return apothem; }
            set { apothem = value; }
        }

        private double base1;
        public double Base1
        {
            get { return base1; }
            set { base1 = value; }
        }

        private double perimeter;
        public double Perimeter
        {
            get { return perimeter; }
            set { perimeter = value; }
        }

        private string type;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }


    }

    //This is a class that is derived/inherits the traits of the Shape class
    //NOTE: We can create ALOT of classes derived from Shapes...can you think of 3 others? 
    //Project: Create 3 other shapes derived from the Shape class that calculate the areas. Google the area functions for
    //your choosen shapes if you can't remember
    class Rectangle : Shape
    {
        public Rectangle() //constructor
        {
            Type = "RECTANGLE";
        }

        public override double Area //keyword is override--- called overriding abstraction.....
        {
            get
            {
                return Height * Width;
            }

        }
    }

    //notice this is derived from Rectangle...that is because a square is a special kind of Rectangle. In fact we could derive ALL
    //4 sided shapes from Trapazoid!
    class Square : Rectangle
    {
        public Square()
        {
            Type = "SQUARE";
        }
    }


    class Circle : Shape
    {
        public Circle()
        {
            Type = "CIRCLE";
        }

        public override double Area
        {
            get
            {
                return 3.14 * Radius * Radius;
            }
        }
    }

    class Triangle : Shape
    {
        public Triangle() //constructor
        {
            Type = "TRIANGLE";
        }

        public override double Area //keyword is override--- called overriding abstraction.....
        {
            get
            {
                return ( Base1 * Height) / 2;
            }

        }
    }

    class Diamond : Shape
    {
        public Diamond() //constructor
        {
            Type = "DIAMOND";
        }

        public override double Area //keyword is override--- called overriding abstraction.....
        {
            get
            {
                return Base1 * Height;
            }

        }
    }

    class Hexagon : Shape
    {
        public Hexagon() //constructor
        {
            Type = "HEXAGON";
        }

        public override double Area //keyword is override--- called overriding abstraction.....
        {
            get
            {
                return (Apothem * Perimeter) / 2;
            }

        }
    }




    //We will create an instance of the Rectangle class and use it to calculate the area and display it.
    class UseRactangle
    {
        static void Main(string[] args)
        {
            //Square sqr = new Square();
            Square Squr = new Square();

            Squr.Height = 3;
            Squr.Width = 3;

            Console.WriteLine("Total area of the square: {0}", Squr.Area);
            Console.ReadKey();

            Rectangle Rect = new Rectangle();

            Rect.Height = 3;
            Rect.Width = 4;

            Console.WriteLine("Total area of the rectangle: {0}", Rect.Area);
            Console.ReadKey();

            Circle Circ = new Circle();

            Circ.Radius = 1;

            Console.WriteLine("Total area of the circle: {0}", Circ.Area);
            Console.ReadKey();

            Triangle Tria = new Triangle();

            Tria.Height = 6;
            Tria.Base1 = 4;

            Console.WriteLine("Total area of the triangle: {0}", Tria.Area);
            Console.ReadKey();

            Diamond Diam = new Diamond();

            Diam.Height = 10;
            Diam.Base1 = 4;

            Console.WriteLine("Total area of the diamond: {0}", Diam.Area);
            Console.ReadKey();

            Hexagon Hexa = new Hexagon();

            Hexa.Apothem = 7;
            Hexa.Perimeter = 4;

            Console.WriteLine("Total area of the hexagon: {0}", Hexa.Area);
            Console.ReadKey();
        }
    }
}

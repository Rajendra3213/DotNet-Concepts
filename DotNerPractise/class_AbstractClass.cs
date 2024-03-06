//using System;
//namespace DotNerPractise
//{
	
//	public class class_AbstractClass
//	{
//        // Abstract class
//        public abstract class Shape
//        {
//            // Abstract method (no implementation)
//            public abstract double CalculateArea();

//            // Regular method with implementation
//            public void DisplayArea()
//            {
//                double area = CalculateArea();
//                Console.WriteLine($"Area: {area}");
//            }
//        }

//        // Derived class
//        public class Circle : Shape
//        {
//            // Fields
//            private double radius;

//            // Constructor
//            public Circle(double radius)
//            {
//                this.radius = radius;
//            }

//            // Implementation of abstract method
//            public override double CalculateArea()
//            {
//                return Math.PI * radius * radius;
//            }
//        }

//        // Derived class
//        public class Rectangle : Shape
//        {
//            // Fields
//            private double length;
//            private double width;

//            // Constructor
//            public Rectangle(double length, double width)
//            {
//                this.length = length;
//                this.width = width;
//            }

//            // Implementation of abstract method
//            public override double CalculateArea()
//            {
//                return length * width;
//            }
//        }

//        public static void Main(string[] args)
//		{
//            Circle circle = new Circle(6);
//            double circleArea = circle.CalculateArea();
//            Console.WriteLine($"Circle Area: {circleArea}");

//            // Call the DisplayArea method from the base class
//            circle.DisplayArea();

//            Console.WriteLine();

//            // Create an instance of Rectangle
//            Rectangle rectangle = new Rectangle(4, 6);

//            // Call the CalculateArea method implemented in Rectangle
//            double rectangleArea = rectangle.CalculateArea();
//            Console.WriteLine($"Rectangle Area: {rectangleArea}");

//            // Call the DisplayArea method from the base class
//            rectangle.DisplayArea();
//            Console.ReadKey();

//        }
//	}
//}


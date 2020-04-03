using System;

namespace HW_03_04_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle h1 = new Rectangle();
            System.Console.Write("Введите длину:");
            double s1=double.Parse(Console.ReadLine());
            System.Console.Write("Введите ширину:");
           double s3=double.Parse(Console.ReadLine());

                h1.side1=s1;
                h1.side3=s3;
                
            System.Console.WriteLine($"result={h1.Area}");
            System.Console.WriteLine($"result={h1.Perimeter}");
            Console.ReadKey();
        }

    }
    class Rectangle
    {
        public double side1 { get; set; }
        public double side3 { get; set; }

        public double Area {get {return AreaCalculator();}}

         public double Perimeter {get {return PerimeterCalulator();}}

        public Rectangle()
        {

        }
        public Rectangle(double side1, double side3)
        {
            this.side1 = side1;
            this.side3 = side3;
        }
        public double AreaCalculator()
        {
            return side1*side3;
            
            
        }
        public double PerimeterCalulator()
        {
            return 2*(this.side1+this.side3);
        }
    }
}

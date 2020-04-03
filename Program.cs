using System;
using System.Collections.Generic;

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
            ///////////////////////////////////////////////////
             
                 Console.Write("Author:"); string Authorq = Console.ReadLine();
            Console.Write("Title:"); string Titleq = Console.ReadLine();
            Console.Write("Content:"); string Contentq = Console.ReadLine();


              Book B=new Book(); 
              Title T=new Title();
              Author A=new Author();
              Content C=new Content();

              Console.ForegroundColor = ConsoleColor.Blue;
                   T.show(Titleq);
            Console.ForegroundColor = ConsoleColor.Red;
             A.show(Authorq);
            Console.ForegroundColor = ConsoleColor.Green;
             C.show(Contentq);
            Console.ForegroundColor = ConsoleColor.White;


                 

               
            
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
  //////////////////////////////////////////////////////////////////////////
     
     class Book
     {
      public string Books {get;set;}

     public  void show(string Books)
      {
        Console.ForegroundColor = ConsoleColor.Red;  
         System.Console.WriteLine(Books);
      }
     }
     class Title
     {
       public string human {get;set;}
          public  void show(string human)
          {
            Console.ForegroundColor = ConsoleColor.Green;  
            System.Console.WriteLine(human);

          }
     }
     class Author
     {
       public string authors {get;set;}
       public  void show(string authors)
       {
         Console.ForegroundColor = ConsoleColor.Blue;  
         System.Console.WriteLine(authors);
       }
     }
     class Content
     {
       public string contents{get;set;}
       public  void show(string contents)
       {
         Console.ForegroundColor = ConsoleColor.Yellow;  
         System.Console.WriteLine(contents);
       }
     }

      
    
                   
           
           
          

           



    
} 

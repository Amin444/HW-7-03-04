﻿using System;
using System.Collections.Generic;

namespace HW_03_04_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle h1 = new Rectangle();
            System.Console.Write("Введите длину:");
            double s1 = double.Parse(Console.ReadLine());
            System.Console.Write("Введите ширину:");
            double s3 = double.Parse(Console.ReadLine());

            h1.side1 = s1;
            h1.side3 = s3;

            System.Console.WriteLine($"result={h1.Area}");
            System.Console.WriteLine($"result={h1.Perimeter}");
            Console.ReadKey();
            ///////////////////////////////////////////////////

            Console.Write("Author:"); string Authorq = Console.ReadLine();
            Console.Write("Title:"); string Titleq = Console.ReadLine();
            Console.Write("Content:"); string Contentq = Console.ReadLine();

            Book r = new Book(){author = new Author(){Aouthorname=Authorq},content = new Content(){includcontent=Contentq},title = new Title(){Titlename=Titleq}};
            r.title.Show();
            r.author.Show();
            r.content.Show();

                    Laptob L=new Laptob()
                    {
                              Names="Dell",
                              Models="Inspires 15 5000",
                              Prices="700$",  
                    };
                            L.GetInfo();

            Console.ReadKey();


        }

    }

    class Rectangle
    {
        public double side1 { get; set; }
        public double side3 { get; set; }

        public double Area { get { return AreaCalculator(); } }

        public double Perimeter { get { return PerimeterCalulator(); } }

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
            return side1 * side3;


        }
        public double PerimeterCalulator()
        {
            return 2 * (this.side1 + this.side3);
        }

        

    }
    //////////////////////////////////////////////////////////////////////////

    class Book
    {
        public Title title { get; set; }
        public Author author { get; set; }
        public Content content { get; set; }
        public Book()
        {
            Title T = new Title();
            Author A = new Author();
            Content C = new Content();

        }
        public Book(string Titlename, string Aouthorname, string includcontent)
        {
            Title T = new Title();
            Author A = new Author();
            Content C = new Content();
            T.Titlename = Titlename;
            A.Aouthorname = Aouthorname;
            C.includcontent = includcontent;
        }
    }
    class Title
    {
        public string Titlename { get; set; }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            System.Console.WriteLine(Titlename);
        }
    }
    class Author
    {
        public string Aouthorname { get; set; }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine(Aouthorname);
        }
    }
    class Content
    {
        public string includcontent { get; set; }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            System.Console.WriteLine(includcontent);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
     class Laptob
     {
            public string Names{get;set;}
            public string Models{get;set;}
            public string Prices{get;set;}

                    public Laptob(string Names,string Models,string Prices)
                    {
                            this.Names=Names;
                            this.Models=Models;
                            this.Prices=Prices;
                    }
               public void GetInfo()
               {
                        System.Console.WriteLine($"Names={Names}");
                        System.Console.WriteLine($"Madels={Models}");
                        System.Console.WriteLine($"Proces={Prices}");
               }
                 
                    public Laptob()
                    {

                    }
     } 



        

}













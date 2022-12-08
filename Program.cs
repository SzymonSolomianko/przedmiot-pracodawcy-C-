// zad1
//Console.WriteLine("PI = {0:#.####}", Math.PI);

// zad2
//Console.WriteLine(Math.Sqrt(Math.PI));

// zad3
//using System;
//class Circle
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Podaj promien: ");
//        double Radious = Convert.ToDouble(Console.ReadLine());
//        double Area = Math.PI * Radious * Radious;
//        Console.WriteLine("Objetosc: " + Area);
//        Console.ReadKey();
//    }

//zad pitagoras
//class Pitagoras
//Console.Write("Podaj liczbę a:");
//double a =  Convert.ToDouble(Console.ReadLine());

//zad5
//Console.WriteLine("Podaj liczbę a");
//int a = int.Parse(Console.ReadLine());
//Console.WriteLine("Podaj liczbę b");
//int b = int.Parse(Console.ReadLine());
//Console.WriteLine(a/b);

//zad6
//Console.WriteLine("Podaj liczbę x");
//int x = int.Parse(Console.ReadLine());
//Console.WriteLine("Podaj liczbę y");
//int y = int.Parse(Console.ReadLine());
//Console.WriteLine("wynik dodawania : {0}", x + y);
//Console.WriteLine("wynik odejmowania : {0}", x - y);
//Console.WriteLine("wynik mnożenia : {0}", x * y);
//Console.WriteLine("wynik dzielenia : {0}", x / y);

//zad7
class zadanie7
{
    static void Main(string[]args)
    {
        int x = 0,  y = 0;
        Console.WriteLine("x od 0 do 10");
        Console.WriteLine();
        Console.Write("y od 0 do 30");
        Console.WriteLine();
        for (x = 0; x <= 10; x++)
        {
            y = 3 * x;
            Console.WriteLine("x=" + x + 't' + "y=" + y);

        }
    }    
    
}
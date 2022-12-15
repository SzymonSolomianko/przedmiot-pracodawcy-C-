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

//zad dodatkowe1

//int sum = 0;
//int i = 1;
//while (i <= 100)
//{
//  sum += i;
//i++;
//}

//Console.WriteLine(sum);

//zad dodatkowe2
//int sum = 0;

//for (int i = 1; i <= 100; i++)
//{
//    if (i % 2 == 0)
//    {
//        sum += i;
//    }
//}
//Console.WriteLine(sum);

//Zad1.
//Napisz program, który za pomocą instrukcji for dla danych wartości x zmieniających się w
//przedziale od 0 do 10 obliczy wartość funkcji y = 3x.
//int x, y ;
//for (x = 0; x <11; x++)
//{
//    y = 3*x;
//    Console.WriteLine("x="+x+" y="+y);

//}
//Zad2.
//Napisz program, który za pomocą instrukcji do ... while dla danych
//wartości x zmieniających się od 0 do 10 oblicza wartość funkcji y = 3x

//int x=0, y=0;
//do
//{
//    y=3*x;
//    Console.WriteLine("x="+x+" y="+y);
//    x++;
//} while (x<11);


//Zad3.
//Napisz program, który za pomocą instrukcji for wyświetla liczby całkowite od 1 do 20.

//for (int x = 0; x <=20 ; x++)
//{
//	if (x<20)
//	{
//		Console.Write(x+",");
//	}
//	else
//	{
//		Console.Write(x+"."); 
//	}
//}

//Zad4.
//Napisz program, który za pomocą instrukcji do ... while wyświetla liczby całkowite od 1 do 20

//int i = 1;

//do
//{
//    Console.WriteLine(i);
//    i++;
//}
//while (i <= 20);

//zad5
//Napisz program, który za pomocą instrukcji while wyświetla liczby całkowite od 1 do 20.

//int x = 1;

//while (x <= 20)
//{
//    Console.WriteLine(x);
//    x++;
//}

//Zad6.
//Napisz program, który za pomocą instrukcji for sumuje liczby całkowite od 1 do 100.
//int sum = 0;

//for (int i = 1; i <= 100; i++)
//{
//    sum += i;
//}

//Console.WriteLine("Suma liczb całkowitych od 1 do 100 wynosi: " + sum);

//Zad7.
//Napisz program, który za pomocą instrukcji do ... while sumuje liczby całkowite od 1 do 100.

//int sum = 0;
//int i = 1;
//do
//{
//    sum += i;
//    i++;
//}
//while (i <= 100);
//Console.WriteLine("Suma liczb całkowitych od 1 do 100 wynosi: " + sum);

//Zad8.
//Napisz program, który za pomocą instrukcji while sumuje liczby całkowite od 1 do 100.

int sum = 0;
int i = 1;
do
{
    sum += i;
    i++;
}
while (i <= 100);
Console.WriteLine("Suma liczb całkowitych od 1 do 100 wynosi: " + sum);
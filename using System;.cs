using System;

class Program
{
    static void Main()
    {
      int numA;
    int numB;
    double numH;
    int iteration = 0;

    Console.Write("Введите A: ");
    numA = int.Parse(Console.ReadLine());

    Console.Write("Введите B: ");
    numB = int.Parse(Console.ReadLine());

    Console.Write("Введите шаг (h): ");
    numH = double.Parse(Console.ReadLine());


    Console.WriteLine("{0,3} {1,5} {2,5}", "#", "x", "f(x)");

    for (double x = numA; x <= numB; x += numH)
    {
        iteration++;
        double y;
        double xplus = x + 2;
        if (xplus <= 1){
            y= x *x;

        }
        else if (xplus <10){
        	y = 1 / (x + 2);
        }
        else
            {
                y = x + 2;
            }
       
        
        Console.WriteLine("{0,3} {1,5:f2} {2,5:f2} ", iteration, x, y);
    }

    
        Console.WriteLine("Нажмите Enter для завершения...");
        Console.ReadLine();
    }
}
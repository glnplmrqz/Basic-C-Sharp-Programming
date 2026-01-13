using System;

class AverageCalculator {
    static void Main(String[] args) {
        // Average Calculator
        double english, math, science, computer, average;

        Console.WriteLine("\n ---------- Grade Average ---------- ");

        // User Input
        Console.Write(" English     : ");
        english = Convert.ToDouble(Console.ReadLine());

        Console.Write(" Math        : ");
        math = Convert.ToDouble(Console.ReadLine());

        Console.Write(" Science     : ");
        science = Convert.ToDouble(Console.ReadLine());

        Console.Write(" Computer    : ");
        computer = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine(" ----------------------------------- ");
        Console.ReadKey();

        // Compute Average 
        average = (english + math + science + computer) / 4;
        Console.WriteLine(" Average     : " + average);
    }
}
using System;

class GradeConditional {

    static void Main(string[] args) {

        // Grade Average Program
        // Science, Math, English, Computer Programming

        double[] grades = new double[4];
        double averageGrade;

        Console.Write("Enter Grade in Science               : ");
        grades[0] = Convert.ToDouble(Console.ReadLine()); // Science

        Console.Write("Enter Grade in Math                  : ");
        grades[1] = Convert.ToDouble(Console.ReadLine()); // Math

        Console.Write("Enter Grade in English               : ");
        grades[2] = Convert.ToDouble(Console.ReadLine()); // English

        Console.Write("Enter Grade in Computer Programming  : ");
        grades[3] = Convert.ToDouble(Console.ReadLine()); // Computer Programming

        // Computing Grade Average Using Array
        averageGrade = (grades[0] + grades[1] + grades[2] + grades[3])/4;

        Console.WriteLine("Average Grade: " +averageGrade);

        if (averageGrade <= 74) {
            Console.WriteLine("Failed");
        } else if (averageGrade <= 89) {
            Console.WriteLine("Passed");
        } else if (averageGrade <= 94) {
            Console.WriteLine("With Honors");
        } else if (averageGrade <= 97) {
            Console.WriteLine("With High Honors");
        } else if (averageGrade <= 100) {
            Console.WriteLine("With Highest Honors");
        } else {
            Console.WriteLine("Invalid Grade");
        }
    }
}
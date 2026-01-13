using System;

class LoopGradeAverage {

    static void Main(string[] args) {

        double[] grades = new double[4];
        double averageGrade;
        char anotherStudent = 'y';

        while (anotherStudent == 'y') {

            Console.Clear();

            Console.WriteLine("\n [===== STUDENT SIMPLE GRADING SYSTEM =====]");

            Console.Write(" Student Name             : ");
            string studentName = Console.ReadLine();

            Console.Write(" Enter 1st Quarter Grade  : ");
            grades[0] = Convert.ToDouble(Console.ReadLine());

            Console.Write(" Enter 2nd Quarter Grade  : ");
            grades[1] = Convert.ToDouble(Console.ReadLine());

            Console.Write(" Enter 3rd Quarter Grade  : ");
            grades[2] = Convert.ToDouble(Console.ReadLine());

            Console.Write(" Enter 4th Quarter Grade  : ");
            grades[3] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" ========================================== ");

            // Grade Average Computation
            averageGrade = (grades[0] + grades[1] + grades[2]+ grades[3])/4;

            Console.WriteLine($" Hello {studentName}");
            Console.WriteLine($" Average Grade is {averageGrade}");

            if (averageGrade >= 75) {
                Console.WriteLine(" Remark is: PASS");
            } else {
                Console.WriteLine(" Remark is: FAIL");
            }
            Console.Write("\n Enter another student? [y/n]: ");
            anotherStudent = char.ToLower(Console.ReadLine()[0]);

            if (char.ToLower(anotherStudent) == 'n') {
                Console.WriteLine("\n --- END OF THE PROGRAM ---");
            } else if (anotherStudent != 'y') {
                Console.WriteLine("\n --- INVALID OPTTION ---");
            }
        }

    }
}
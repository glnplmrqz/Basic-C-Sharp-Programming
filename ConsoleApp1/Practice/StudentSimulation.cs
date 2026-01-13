using System;

namespace PracticeCSharp {

    class Students {

        string firstName { get; set; }
        string lastName { get; set; }
        int year { get; set; }
        string course { get; set; }
        char section { get; set; }

        public Students(string firstName, string lastName, int year, string course, char section) {

            this.firstName = firstName;
            this.lastName = lastName;
            this.year = year;
            this.course = course;
            this.section = section;
        }

        public void displayStudent(int index) {
            Console.WriteLine($"\n Student #{index + 1} ");
            Console.WriteLine($" Full Name: {lastName}, {firstName}");
            Console.WriteLine($" Year Level: {year}");
            Console.WriteLine($" Course: {course}");
            Console.WriteLine($" Section: {section}");
        }

    }

    class StudentSimulation{

        static void Main(string[] args) {

            Console.Write("\n Number of Students: ");
            int many = Convert.ToInt32(Console.ReadLine());

            Students[] students = new Students[many];

            for (int i = 0; i < many; i++) {

                Console.Write("\n Enter First Name: ");
                string firstName = Console.ReadLine();

                Console.Write(" Enter Last Name: ");
                string lastName = Console.ReadLine();

                Console.Write(" Enter Year Level: ");
                int year = Convert.ToInt32(Console.ReadLine());

                Console.Write(" Enter Student Course: ");
                string studentCourse = Console.ReadLine();

                Console.Write(" Enter Section: ");
                char section = Console.ReadLine()[0];

                students[i] = new Students(firstName, lastName, year, studentCourse, section);
            }

            int index = 0;

            foreach (Students student in students) {
                student.displayStudent(index);
                index++;
            }
        }
    }
}
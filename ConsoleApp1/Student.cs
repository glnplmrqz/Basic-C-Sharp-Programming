using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCSharp {
   
   class Student {

        string firstName, lastName, course;
        int yearLevel;
        double midtermGrade, finalGrade;
        char section;


        // Constructor for Student Class
        public Student(string firstName, string lastName, int yearLevel, string course, char section, double midtermGrade, double finalGrade) {
            this.firstName = firstName;
            this.lastName = lastName;
            this.yearLevel = yearLevel;
            this.course = course;
            this.section = section;
            this.midtermGrade = midtermGrade;
            this.finalGrade = finalGrade;
        }

        // Functions for Introduce Student
        public void introduce() {

            // For Full Name
            string fullName = $"{lastName}, {firstName}";

            Console.WriteLine();
            Console.WriteLine($" Full Name: {fullName}");
            Console.WriteLine($" Year Level: {yearLevel}");
            Console.WriteLine($" Course: {course}");
            Console.WriteLine($" Section: {section}");
        }

        // Functions For Evaluating Grade
        public void evaluateGrade() {

            Console.WriteLine($" Midterm Grade: {midtermGrade}");
            Console.WriteLine($" Final Grade: {finalGrade}");

            // Computing Average Grade
            double average = (midtermGrade + finalGrade)/2;

            Console.WriteLine($" Average Grade: {average}");

            // Remarks - Honor, Passed, Failed

            if (average >= 90) Console.WriteLine(" Remarks: Honor");
            else if (average >= 75) Console.WriteLine(" Remarks: Passed");
            else Console.WriteLine(" Remarks: Failed");
        }
    }
}

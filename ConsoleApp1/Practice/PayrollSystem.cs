using System;

namespace PracticeCSharp {

    class Employee {

        public int employeeID { get; set; }
        public string name { get; set; }
        public string position { get; set; }
        public double ratePerDay { get; set; }
        public int daysWorked { get; set; }

        public Employee(int employeeID, string name, string position, double ratePerDay, int daysWorked) {
            this.employeeID = employeeID;
            this.name = name;
            this.position = position;
            this.ratePerDay = ratePerDay;
            this.daysWorked = daysWorked;
        }

        public virtual void employeeInfo() {
            Console.WriteLine("\n ==========================================");
            Console.WriteLine("\n\tEMPLOYEE PAYROLL SYSTEM ");
            Console.WriteLine("\n ==========================================");

            // Display Employee Info

            Console.WriteLine($"\n Employee ID        : {employeeID}");
            Console.WriteLine($" Employee Name      : {name}");
            Console.WriteLine($" Employee Position  : {position}");
            Console.WriteLine($"\n Rate Per Day       : {ratePerDay}");
            Console.WriteLine($" Days Worked        : {daysWorked}");

            Console.WriteLine("\n ------------------------------------------");
        }

    }

    class Payroll : Employee {

        // Inherit Constructor from Employee Class
        public Payroll(int employeeID, string name, string position, double ratePerDay, int daysWorked) : base(employeeID, name, position, ratePerDay, daysWorked) {

        }

        public double grossSalary { get; set; }
        public double deduction { get; set; }
        public double netSalary { get; set; }

        // Compute Gross Salary
        public double computeGrossSalary() {
            grossSalary = ratePerDay * daysWorked;
            return grossSalary;
        }

        // Compute Deduction
        public double computeDeduction() {
            deduction = grossSalary * 0.10;
            return deduction;
        }

        // Compute Net Salary
        public double computeNetSalary() {
            netSalary = grossSalary - deduction;
            return netSalary;
        }

        public override void employeeInfo() {
            base.employeeInfo(); // Inherit from Employee Class
            Console.WriteLine($" Gross Salary       : {computeGrossSalary()}");
            Console.WriteLine($" Deduction (10%)    : {computeDeduction()}");
            Console.WriteLine(" ------------------------------------------");
            Console.WriteLine($" Net Salary         : {computeNetSalary()}");
        }

    }

    class PayrollSystem {

        static void Main(string[] args) {

            // User Input
            Console.Write("\n Input Employee ID    : ");
            int inputEmployeeID = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Input Employee Name  : ");
            string inputName = Console.ReadLine();

            Console.Write(" Input Position       : ");
            string inputPosition = Console.ReadLine();

            Console.Write(" Input Rate Per Day   : ");
            double inputRatePerDay = Convert.ToDouble(Console.ReadLine());

            Console.Write(" Input Days Worked    : ");
            int inputDaysWorked = Convert.ToInt32(Console.ReadLine());

            Payroll payroll = new Payroll(inputEmployeeID, inputName, inputPosition, inputRatePerDay, inputDaysWorked);
            Console.Clear();
            payroll.employeeInfo();
        }
    }

}
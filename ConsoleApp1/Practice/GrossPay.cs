using System;

class GrossPay {
    static void Main(string[] args) {
        // Gross Pay Computation
        string employeeName, status, department;
        int employeeID, daysWorked, dailyRate;

        Console.WriteLine("\n ---------- WELCOME TO BASIC PAYROLL SAMPLE ---------");

        // User Input
        Console.Write(" Enter your name  : ");
        employeeName = Console.ReadLine();

        Console.Write(" Employee ID      : ");
        employeeID = Convert.ToInt32(Console.ReadLine());

        Console.Write(" Status           : ");
        status = Console.ReadLine();

        Console.Write(" Department       : ");
        department = Console.ReadLine();

        Console.Write("\n Days Worked      : ");
        daysWorked = Convert.ToInt32(Console.ReadLine());

        Console.Write(" Daily Rate       : ");
        dailyRate = Convert.ToInt32(Console.ReadLine());

        Console.ReadKey();

        // Display Receipt
        Console.WriteLine(" ----------------- PAY SLIP RECEIPT -----------------");
        Console.WriteLine(" Employee Name    : " + employeeName);
        Console.WriteLine(" Employee ID      : " + employeeID);
        Console.WriteLine(" Emp Status       : " + status);
        Console.WriteLine(" Department       : " + department);
        Console.WriteLine(" Days Worked      : " + daysWorked + " Days.");
        Console.WriteLine(" Daily Rate       : " + dailyRate + " Pesos.");

        // Gross Pay
        double grossPay = daysWorked * dailyRate;
        Console.WriteLine(" Gross Pay        : " + grossPay);

        Console.ReadKey();

        // Total Deductions
        Console.WriteLine(" --------------------- DEDUCTIONS -------------------");
        double lessTax = 350.75, pagibig = 100.5;
        int sss = 500, philhealth = 100;

        Console.WriteLine(" LESS TAX         : " + lessTax);
        Console.WriteLine(" SSS              : " + sss);
        Console.WriteLine(" Philhealth       : " + philhealth);
        Console.WriteLine(" Pag-Ibig         : " + pagibig);

        // Total Deductions
        double totalDeductions = lessTax + sss + philhealth + pagibig;
        Console.WriteLine("\n Total Deductions : " + totalDeductions);

        Console.ReadKey();
        Console.WriteLine(" ----------------------------------------------------");

        // Net Pay
        double netPay = grossPay - totalDeductions;
        Console.WriteLine(" Total Net Pay    : " + netPay + " Pesos");
    }
}
using System;

class DateFormatter {

    static void Main(string[] args) {
        // Date Formatter

        int month, date, year;
        string monthName = "";

        Console.Write("Month    : ");
        month = Convert.ToInt32(Console.ReadLine());

        Console.Write("Date     : ");
        date = Convert.ToInt32(Console.ReadLine());

        Console.Write("Year     : ");
        year = Convert.ToInt32(Console.ReadLine());

        switch (month) {
            case 1:
                monthName = "January";
                break;
            case 2:
                monthName = "February";
                break;
            case 3:
                monthName = "March";
                break;
            case 4:
                monthName = "April";
                break;
            case 5:
                monthName = "May";
                break;
            case 6:
                monthName = "June";
                break;
            case 7:
                monthName = "July";
                break;
            case 8:
                monthName = "August";
                break;
            case 9:
                monthName = "September";
                break;
            case 10:
                monthName = "October";
                break;
            case 11:
                monthName = "November";
                break;
            case 12:
                monthName = "December";
                break;
            default:
                Console.WriteLine("Invalid Month");
                break;
        }

        if (month > 0 && month <= 12) {

            if (date > 0 && date < 32) {
                Console.WriteLine($"{monthName} {date}, {year}");
            } else {
                Console.WriteLine("Invalid Date");
            }
        }
    }
}
using System;

class Vaccine {

    static void Main(string[] args) {

        Console.WriteLine("\n PROGRAMMED BY  : MARQUEZ, GLEN PAUL");
        Console.WriteLine(" SECTION        : BTLED-ICT 3A");
        Console.WriteLine(" SUBJECT        : C# PROGRAMMING");
        Console.WriteLine(" TOPIC          : CONDITIONAL STATEMENT AND SWITCH STATEMENT ");

        string[] vaccine = {
                       "BioNTech, Pfizer Vaccine",
                       "Moderna Vaccine",
                       "Sputnik V Vaccine",
                       "Novavax Vaccine",
                       "Oxford, AstraZeneca Vaccine",
                       "Johnson & Johnson Vaccine",
                       "Sinovac Vaccine"
        };

        Console.WriteLine("\n [======== WELCOME TO RESBAKUNA FORM =======] ");

        Console.WriteLine("\n ENTER YOUR DETAILS BELOW: \n");

        // User Input
        Console.Write(" FULL NAME      : ");
        string fullName = Console.ReadLine();

        Console.Write(" GENDER         : ");
        string gender = Console.ReadLine();

        Console.Write(" AGE            : ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write(" CONTACT        : ");
        long contactNo = Convert.ToInt64(Console.ReadLine());

        // Display Output from the User Input
        Console.WriteLine(" ========================================================");
        Console.WriteLine($" FULL NAME      : {fullName}");
        Console.WriteLine($" GENDER         : {gender}");
        Console.WriteLine($" AGE            : {age}");
        Console.WriteLine($" CONTACT        : {contactNo}");
        Console.WriteLine(" ========================================================");

        if (age >= 12) {
            Console.WriteLine($" YOUR AGE IS    : {age}");
            Console.WriteLine(" REMARKS        : QUALIFIED FOR COVID-19 VACCINATION");

            // List of Vaccine
            Console.WriteLine(" ***************** [CHOOSE YOUR VACCINE BELOW ] *****************");
            Console.WriteLine("     [ CODE ]           [ BRAND ]");
            Console.WriteLine("        1               BioNTech, Pfizer Vaccine");
            Console.WriteLine("        2               Moderna Vaccine");
            Console.WriteLine("        3               Sputnik V Vaccine");
            Console.WriteLine("        4               Novavax Vaccine");
            Console.WriteLine("        5               Oxford, AstraZeneca Vaccine");
            Console.WriteLine("        6               Johnson & Johnson Vaccine");
            Console.WriteLine("        7               Sinovac Vaccine");
            Console.WriteLine(" ****************************************************************");

            // User Input For Selecting What Vaccine
            Console.Write("\n ENTER VACCINE CODE: ");
            int vaccineCode = Convert.ToInt32(Console.ReadLine());

            switch (vaccineCode) {
                case 1:
                    Console.WriteLine($" You Choose {vaccineCode}: {vaccine[0]}");
                    break;
                case 2:
                    Console.WriteLine($" You Choose {vaccineCode}: {vaccine[1]}");
                    break;
                case 3:
                    Console.WriteLine($" You Choose {vaccineCode}: {vaccine[2]}");
                    break;
                case 4:
                    Console.WriteLine($" You Choose {vaccineCode}: {vaccine[3]}");
                    break;
                case 5:
                    Console.WriteLine($" You Choose {vaccineCode}: {vaccine[4]}");
                    break;
                case 6:
                    Console.WriteLine($" You Choose {vaccineCode}: {vaccine[5]}");
                    break;
                case 7:
                    Console.WriteLine($" You Choose {vaccineCode}: {vaccine[6]}");
                    break;
                default:
                    Console.WriteLine(" You've Entered Invalid Vaccine Code, Try Again!");
                    System.Environment.Exit(0); // automatically exits the program and not display from protektodo sa bakunang sigurado until the last line
                    break;
            }
        } else {
            Console.WriteLine(" REMARKS        : YOU'RE NOT QUALIFIED IN COVID-19 VACCINATION");
        }

        Console.WriteLine("\n ProtekTODO sa Bakunang Sigurado");
        Console.WriteLine("\n # STAY HOME. SAVE LIVES #");
        Console.WriteLine("   Help stop coronavirus...");
        Console.WriteLine("\n                          PROGRAM WELL DONE ");
        Console.WriteLine(" !!<==NOTE: THIS PROGRAM IS MADE FOR STUDENTS' PRACTICAL TEST ==>!!");
    }
}
using System;

class PairIndex {
    static void Main(string[] args) {
        string[] usernames = { "glnplmrqz", "miyeaah" };
        string[] passwords = { "1234admin", "yah01232" };
        string[] emails = { "glenpaulmarquez01@gmail.com", "baltazarshermiahcyrene@gmail.com" };

        Console.Write(" Index    : ");
        int index = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(" Username : " + usernames[index]);
        Console.WriteLine(" Email    : " + emails[index]);
        Console.WriteLine(" Password : " + passwords[index]);
    }
}
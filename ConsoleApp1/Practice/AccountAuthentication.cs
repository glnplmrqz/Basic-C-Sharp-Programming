using System;

class AccountAuthentication {

    static void Main(string[] args) {
        string[] usernames = { "glnplmrqz", "toosmooth", "shai" };
        string[] passwords = { "pogi123", "cantcant23", "jellyace02" };
        bool isFound = false;

        Console.Write("Username : ");
        string enterUser = Console.ReadLine();

        Console.Write("Password : ");
        string enterPass = Console.ReadLine();

        for (int i = 0; i < usernames.Length; i++) {

            if (usernames[i].Equals(enterUser) && passwords[i].Equals(enterPass)) {
                Console.WriteLine($"Welcome, {enterUser}");
                isFound = true;
                break;
            }

        }
        if (!isFound) {
            Console.WriteLine("Account Not Found!");
        }
    }
}
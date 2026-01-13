using System;

namespace PracticeCSharp {

    class RandomPinNo {

        static void Main(string[] args) {

            // Pin Generator
            Random random = new Random();

            string character = "0123456789";
            string pinNumber = "";

            for (int i = 0; i < 4; i++) {
                pinNumber += random.Next(character.Length);
            }

            Console.WriteLine($"Pin Number: {pinNumber}");
        }
    }
}
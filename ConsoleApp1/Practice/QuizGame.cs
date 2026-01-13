using System;

class QuizGame {

    static void Main(string[] args) {

        // Quiz Lives Games

        int lives = 3;
        string correctAnswer = "Seoul";

        while (lives > 0) {

            Console.WriteLine($"Life Counter: {lives}");
            Console.Write("What is the Capital of South Korea? ");
            string answer = Console.ReadLine();

            if (answer.Equals(correctAnswer, StringComparison.CurrentCultureIgnoreCase)) {
                Console.WriteLine("You're answer was correct!");
                Console.WriteLine("You Won!");
                break;
            } else {
                lives--;
            }
        }
        if (lives == 0) {
            Console.WriteLine("You Lost!");
        }
    }
}
using System;

class TestNumber {

    static void Main(string[] args) {

        // Test Number

        int testNumber, score;
        float weightedScore;

        Console.Write("Input Test Number: ");
        testNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input Score: ");
        score = Convert.ToInt32(Console.ReadLine());

        switch (testNumber) {
            case 1:
                weightedScore = score * 0.10f;
                Console.WriteLine($"A score of {score} on test {testNumber} gives a weighted score of {weightedScore}");
                break;
            case 2:
            case 3:
                weightedScore = score * 0.20f;
                Console.WriteLine($"A score of {score} on test {testNumber} gives a weighted score of {weightedScore}");
                break;
            case 4:
            case 5:
                weightedScore = score * 0.15f;
                Console.WriteLine($"A score of {score} on test {testNumber} gives a weighted score of {weightedScore}");
                break;
            case 6:
                weightedScore = score * 0.29f;
                Console.WriteLine($"A score of {score} on test {testNumber} gives a weighted score of {weightedScore}");
                break;
            default:
                Console.WriteLine("Invalid Test Number, Try Again...");
                break;
        }
    }
}
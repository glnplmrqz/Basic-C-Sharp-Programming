using System;

class SummationUsingFunction {

    static void Main(string[] args) {
        int[] numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 20, 25];

        int result = summation(numbers);

        Console.WriteLine($"Total: {result}");
    }

    static int summation(int[] numbers) {
        int sum = 0;

        foreach (int num in numbers) {
            sum += num;
        }

        return sum;
    }
}
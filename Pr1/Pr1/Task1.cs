using System;

namespace TaskNamespace
{
    public class Task1
    {
        public void Execute()
        {
            const int serialNumber = 11;

            int num = serialNumber % 10;
            int min = 1;
            int max = 10 + num;

            Console.WriteLine("Enter three numbers:");
            if (!int.TryParse(Console.ReadLine(), out int a) ||
                !int.TryParse(Console.ReadLine(), out int b) ||
                !int.TryParse(Console.ReadLine(), out int c))
            {
                Console.WriteLine("Invalid input. Please enter valid numbers.");
                return;
            }

            Console.WriteLine($"Numbers that belong to the interval [{min},{max}]:");
            if (IsInRange(a, min, max)) Console.WriteLine(a);
            if (IsInRange(b, min, max)) Console.WriteLine(b);
            if (IsInRange(c, min, max)) Console.WriteLine(c);
        }

        private bool IsInRange(int number, int min, int max)
        {
            return number >= min && number <= max;
        }
    }
}
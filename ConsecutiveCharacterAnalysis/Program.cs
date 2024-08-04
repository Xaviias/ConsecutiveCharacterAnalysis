using System;

namespace ConsecutiveCharacterAnalysis
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string? input = Console.ReadLine();

            if(input == null) { return; }

            int maxUnequalConsecutive = MaxUnequalConsecutiveCharacters(input);
            int maxIdenticalConsecutiveLetters = MaxConsecutiveIdenticalLetters(input);
            int maxIdenticalConsecutiveDigits = MaxConsecutiveIdenticalDigits(input);

            Console.WriteLine($"Maximum number of unequal consecutive characters: {maxUnequalConsecutive}");
            Console.WriteLine($"Maximum number of consecutive identical letters: {maxIdenticalConsecutiveLetters}");
            Console.WriteLine($"Maximum number of consecutive identical digits: {maxIdenticalConsecutiveDigits}");
        }

        public static int MaxUnequalConsecutiveCharacters(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }

            int maxCount = 0;
            int currentCount = 1;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] != input[i - 1])
                {
                    currentCount++;
                }
                else
                {
                    maxCount = Math.Max(maxCount, currentCount);
                    currentCount = 1;
                }
            }

            return Math.Max(maxCount, currentCount);
        }

        public static int MaxConsecutiveIdenticalLetters(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }

            int maxCount = 0;
            int currentCount = 1;

            for (int i = 1; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]) && input[i] == input[i - 1])
                {
                    currentCount++;
                }
                else
                {
                    maxCount = Math.Max(maxCount, currentCount);
                    currentCount = 1;
                }
            }

            return Math.Max(maxCount, currentCount);
        }

        public static int MaxConsecutiveIdenticalDigits(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }

            int maxCount = 0;
            int currentCount = 1;

            for (int i = 1; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]) && input[i] == input[i - 1])
                {
                    currentCount++;
                }
                else
                {
                    maxCount = Math.Max(maxCount, currentCount);
                    currentCount = 1;
                }
            }

            return Math.Max(maxCount, currentCount);
        }
    }
}

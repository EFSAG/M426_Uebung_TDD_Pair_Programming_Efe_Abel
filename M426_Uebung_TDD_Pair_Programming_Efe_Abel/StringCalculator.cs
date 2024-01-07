using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M426_Uebung_TDD_Pair_Programming_Efe_Abel
{
    public class StringCalculator
    {
        public int CalledCount { get; private set; }

        public int Add(string numbers)
        {
            CalledCount++;

            if (string.IsNullOrEmpty(numbers))
            {
                return 0;
            }

            var delimiters = new List<char> { ',', '\n' };

            if (numbers.StartsWith(";"))
            {
                delimiters.Add(';');
                numbers = numbers.Substring(2);
            }

            string[] numberArray = numbers.Split(delimiters.ToArray());

            int sum = 0;
            List<int> negativeNumbers = new List<int>();

            foreach (var num in numberArray)
            {
                if (!string.IsNullOrEmpty(num))
                {
                    int number = int.Parse(num);

                    if (number < 0)
                    {
                        negativeNumbers.Add(number);
                    }
                    else if (number <= 1000)
                    {
                        sum += number;
                    }
                }
            }

            if (negativeNumbers.Count > 0)
            {
                throw new InvalidOperationException($"negatives not allowed: {string.Join(", ", negativeNumbers)}");
            }

            return sum;
        }

        public void AddFromUserInput()
        {
            Console.WriteLine("Bitte geben Sie die Zahlen ein, die Sie addieren möchten (getrennt durch Kommas):");
            string numbers = Console.ReadLine();
            int result = Add(numbers);
            Console.WriteLine($"Die Summe ist: {result}");
        }
    }

}

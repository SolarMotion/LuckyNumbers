using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var allIntegers = new List<int>();
            var selectedIntegers = new List<int>();

            for (int i = 1; i < 64; i++)
                allIntegers.Add(i);

            while (selectedIntegers.Count < 6)
            {
                var randomNumber = random.Next(0, 62);

                var selectedInteger = allIntegers[randomNumber];

                if (!selectedIntegers.Any(a => a.Equals(selectedInteger)))
                    selectedIntegers.Add(selectedInteger);
            }

            selectedIntegers = selectedIntegers.OrderBy(a => a).ToList();
            var finalResult = string.Join(", ", selectedIntegers);

            WriteLine($"The lucky numbers is: {finalResult}");

            ReadLine();
        }
    }
}

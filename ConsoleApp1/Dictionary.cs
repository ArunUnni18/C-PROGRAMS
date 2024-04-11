using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Dictionary
    {
        public static void UsingDictionary()
        {
            int[] array = { 1, 2, 3, 4, 5, 1, 2, 3, 2, 2, 2 }; // Example array

            // Dictionary to store frequencies of elements
            Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

            // Count frequencies of each element in the array
            foreach (int num in array)
            {
                if (frequencyMap.ContainsKey(num))
                {
                    frequencyMap[num]++;
                }
                else
                {
                    frequencyMap[num] = 1;
                }
            }

            // Find the most repeated value
            int mostRepeatedValue = frequencyMap.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;

            // Print the most repeated value
            Console.WriteLine($"The most repeated value is: {mostRepeatedValue}");
            Console.WriteLine($"The count is: {frequencyMap[mostRepeatedValue]}");
        }
    }
}

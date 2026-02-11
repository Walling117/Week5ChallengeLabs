using System.Globalization;

namespace Week5ChallengeLabs
{
    internal class Program
    {
        public static int FindSingleNumber(int[] array)
        {
            Dictionary<int,int> dictionary = new Dictionary<int,int>();
            for(int i = 0; i < array.Length; i++)
            {
                if (dictionary.ContainsKey(array[i]))
                    dictionary.Remove(array[i]);
                else
                {
                    dictionary.Add(array[i], 1);
                }
            }            
            return dictionary.Keys.First();
        }

        public static int FindMissingNumber(int[] array)
        {
            int n = array.Length;
            int expectedSum = n * (n + 1) / 2;
            int acutualSum = 0;
            foreach (int i in array)
            {
                acutualSum += i;
            }
            return expectedSum - acutualSum;
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.WriteLine("Find Single Number");
            Console.WriteLine("Input: [9,6,4,2,3,5,7,0,1]");
            Console.WriteLine($"Output: [{FindMissingNumber(new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 })}]");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("Find single number");
            Console.WriteLine("Input: [4,1,2,1,2]");
            Console.WriteLine($"Output: {FindSingleNumber(new int[] {4, 1, 2, 1, 2})}");

        }
    }
}

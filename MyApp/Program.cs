using System;
namespace MyApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 1, 2 };
            var result = FindLargestAndSmallest(arr);
            Console.WriteLine($" Largest : {result.a}, Smallest: {result.b}");
        }
        public static (int a, int b) FindLargestAndSmallest(int[] nums)
        {
            int smallest = nums[0];
            int largest = nums[0];
            foreach ( int num in nums)
            {
                if (num > largest)
                {
                    largest = num;
                }
                if (num < smallest)
                {
                    smallest = num;
                }
            }
            return (largest, smallest);
        }
    }
}

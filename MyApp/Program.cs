using System;
namespace MyApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 1, 2 };
            ReverseArray(arr);
            Console.WriteLine($" Reversed Array: {string.Join(", ", arr)}S");
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
        public static void ReverseArray(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;
            while (left < right)
            {
                int temp = nums[left];
                nums[left] = nums[right];
                nums[right] = temp;
                left++;
                right--;
            }
        }
    }
}

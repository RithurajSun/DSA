using System;
namespace MyApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 1, 2 };
            var secondLargest = SecondLargest(arr);
            Console.WriteLine($"The second largest element in the array is {secondLargest} ");
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
            public static int SecondLargest(int[] nums)
        {
            int largest = int.MinValue;
            int secondLargest = int.MinValue;
            foreach( int num in nums)
            {
                if ( num > largest)
                {
                    secondLargest = largest;
                    largest = num;
                }
                else if ( num > secondLargest && num != largest)
                {
                    secondLargest = num;
                }
            }
            return secondLargest;
        }
    }
}

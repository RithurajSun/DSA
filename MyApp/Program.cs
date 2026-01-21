using System;
namespace MyApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 1, 2 };
            var avg = AverageOfArray(arr);
            Console.WriteLine($"The average of the elements in the array is {avg} ");
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
        public static int SumOfArray(int[] nums)
        {
            int sum = 0;
            foreach (int num in nums)
            {
                sum += num;
            }
            return sum;
        }
        public static double AverageOfArray(int[] nums)
        {
            double sum = 0;
            double avg = 0, i = 0;
            foreach (int num in nums)
            {
                sum += num;
                i++;
            }
            avg = sum / i;
            return avg;

        }
    }
}

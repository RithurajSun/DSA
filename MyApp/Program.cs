using System;
namespace MyApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1 ,2 ,3 ,4, 6, 7};
            int result = MissingNumber(arr);
            Console.WriteLine($"The missing element in the array is {result}");
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
        public static void MoveZeroesToEnd(int[] nums){
            int count = 0; 
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[count++] = nums[i];
                }
            }
            while (count < nums.Length)
            {
                nums[count++] = 0;
            }
        }
        public static int MissingNumber(int[] nums)
        {
            int n = nums.Length + 1;
            int expectedSum = n * (n +1)/2;
            int actualSum = 0;
            foreach (int num in nums)
            {
                actualSum += num;
            }
            return expectedSum - actualSum;
        }
    }
}

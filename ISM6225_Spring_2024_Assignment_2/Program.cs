using System;
using System.Collections.Generic;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 1: Find Missing Numbers in Array
            Console.WriteLine("Question 1:");
            int[] nums1 = {3, 1, 2, 4 ,5, 9};
            IList<int> missingNumbers = FindMissingNumbers(nums1);
            Console.WriteLine(string.Join(",", missingNumbers));

            // Question 2: Sort Array by Parity
            Console.WriteLine("Question 2:");
            int[] nums2 = { 3, 1, 2, 4 ,5, 9};
            int[] sortedArray = SortArrayByParity(nums2);
            Console.WriteLine(string.Join(",", sortedArray));

            // Question 3: Two Sum
            Console.WriteLine("Question 3:");
            int[] nums3 = { 2, 7, 11, 15 };
            int target = 18;
            int[] indices = TwoSum(nums3, target);
            Console.WriteLine(string.Join(",", indices));

            // Question 4: Find Maximum Product of Three Numbers
            Console.WriteLine("Question 4:");
            int[] nums4 = { 1, 2, 3, 1, 2, 4 ,5, 9, 10};
            int maxProduct = MaximumProduct(nums4);
            Console.WriteLine(maxProduct);

            // Question 5: Decimal to Binary Conversion
            Console.WriteLine("Question 5:");
            int decimalNumber = 6;
            string binary = DecimalToBinary(decimalNumber);
            Console.WriteLine(binary);

            // Question 6: Find Minimum in Rotated Sorted Array
            Console.WriteLine("Question 6:");
            int[] nums5 = { 3, 4, 5, 1, 2 };
            int minElement = FindMin(nums5);
            Console.WriteLine(minElement);

            // Question 7: Palindrome Number
            Console.WriteLine("Question 7:");
            int palindromeNumber = 1212;
            bool isPalindrome = IsPalindrome(palindromeNumber);
            Console.WriteLine(isPalindrome);

            // Question 8: Fibonacci Number
            Console.WriteLine("Question 8:");
            int n = 4;
            int fibonacciNumber = Fibonacci(n);
            Console.WriteLine(fibonacciNumber);
        }

        // Question 1: Find Missing Numbers in Array
        public static IList<int> FindMissingNumbers(int[] nums)
        {
            try
            {
                // Use a HashSet to store unique elements of the array
                if (nums.Length == 0) return new List<int>();
                HashSet<int> numSet = new HashSet<int>(nums);
                List<int> missing = new List<int>();

                // Check for numbers from 1 to N that are missing from the HashSet
                for (int i = 1; i <= nums.Length; i++)
                {
                    if (!numSet.Contains(i)) missing.Add(i);
                }
                return missing;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 2: Sort Array by Parity
        public static int[] SortArrayByParity(int[] nums)
        {
            try
            {
                // Separate even and odd numbers
                List<int> even = new List<int>();
                List<int> odd = new List<int>();
                foreach (int num in nums)
                {
                    if (num % 2 == 0) even.Add(num);
                    else odd.Add(num);
                }

                // Append odd numbers to even list
                even.AddRange(odd);
                return even.ToArray();
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 3: Two Sum
        public static int[] TwoSum(int[] nums, int target)
        {
            try
            {
                // Use dictionary to store value and its index
                Dictionary<int, int> map = new Dictionary<int, int>();
                for (int i = 0; i < nums.Length; i++)
                {
                    int complement = target - nums[i];
                    // If complement exists in dictionary, return the pair of indices
                    if (map.ContainsKey(complement))
                        return new int[] { map[complement], i };
                    map[nums[i]] = i;
                }
                return new int[0]; // Return empty array if no solution found
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 4: Find Maximum Product of Three Numbers
        public static int MaximumProduct(int[] nums)
        {
            try
            {
                // Sort array to easily pick the largest and smallest values
                if (nums.Length < 3) return 0;
                Array.Sort(nums);
                int n = nums.Length;

                // Compare product of three largest numbers and two smallest with largest
                return Math.Max(nums[n - 1] * nums[n - 2] * nums[n - 3], nums[0] * nums[1] * nums[n - 1]);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 5: Decimal to Binary Conversion
        public static string DecimalToBinary(int decimalNumber)
        {
            try
            {
                // Use built-in Convert method to get binary string
                return Convert.ToString(decimalNumber, 2);
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 6: Find Minimum in Rotated Sorted Array
        public static int FindMin(int[] nums)
        {
            try
            {
                // Use binary search to find minimum element in rotated sorted array
                int left = 0, right = nums.Length - 1;
                while (left < right)
                {
                    int mid = left + (right - left) / 2;
                    // If middle element is greater than right, min must be in right half
                    if (nums[mid] > nums[right]) left = mid + 1;
                    else right = mid; // Else, min is in left half or at mid
                }
                return nums[left];
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 7: Palindrome Number
        public static bool IsPalindrome(int x)
        {
            try
            {
                // Negative numbers are not palindrome
                if (x < 0) return false;

                int reversed = 0, original = x;
                // Reverse the number
                while (x > 0)
                {
                    reversed = reversed * 10 + x % 10;
                    x /= 10;
                }
                // Compare original with reversed
                return original == reversed;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 8: Fibonacci Number
        public static int Fibonacci(int n)
        {
            try
            {
                // Return n for base cases 0 and 1
                if (n <= 1) return n;

                int a = 0, b = 1;
                // Iteratively calculate Fibonacci number
                for (int i = 2; i <= n; i++)
                {
                    int temp = a + b;
                    a = b;
                    b = temp;
                }
                return b;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
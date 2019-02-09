using System;
using System.Collections.Generic;

namespace Assignment2_S19
{
    class Program
    {
        static void Main(string[] args)
        {
            // left rotation
            Console.WriteLine("Left Rotation");
            int d = 4;
            int[] a = { 1, 2, 3, 4, 5 };
            int[] r = rotLeft(a, d);
            displayArray(r);

            // Maximum toys
            Console.WriteLine("\n\nMaximum toys");
            int k = 50;
            int[] prices = { 1, 12, 5, 111, 200, 1000, 10 };
            Console.WriteLine(maximumToys(prices, k));

            // Balanced sums
            Console.WriteLine("\n\nBalanced sums");
            List<int> arr = new List<int> { 1, 2, 3 };
            Console.WriteLine(balancedSums(arr));

            // Missing numbers
            Console.WriteLine("\n\nMissing numbers");
            int[] arr1 = { 203, 204, 205, 206, 207, 208, 203, 204, 205, 206 };
            int[] brr = { 203, 204, 204, 205, 206, 207, 205, 208, 203, 206, 205, 206, 204 };
            int[] r2 = missingNumbers(arr1, brr);
            displayArray(r2);

            // grading students
            Console.WriteLine("\n\nGrading students");
            int[] grades = { 73, 67, 38, 33 };          // original given array of grades
            Console.WriteLine("Original marks before rounding off the grade:");
            displayArray(grades);                       // displaying given array of grades before rounding off
            bool check = true;
            for (int j = 0; j < grades.Length; j++)     // for loop used for iteration and checking if all the numbers are between 0 to 100
            {
                if (grades[j] < 0 || grades[j] > 100) // checking validation - all the grades should be between 0 to 100
                {
                    Console.WriteLine("\nall the grades should be between 0 to 100.");
                    check = false;
                }
            }
            if (check)      // in this block, if all the numbers are between 0 to 100 then we will call method and start applying the round off rules
            {
                int[] r3 = gradingStudents(grades);         // calling function to apply conditions and round off grades and getting result in array r3
                Console.WriteLine("\nMarks after rounding off the grade:");
                displayArray(r3);                           // displaying array of grades after rounding off
            }
                Console.ReadKey();

            // find the median
            Console.WriteLine("\n\nFind the median");
            int[] arr2 = { 0, 1, 2, 4, 6, 5, 3};
            Console.WriteLine("Original given array of numbers:");
            displayArray(arr2);                       // displaying given array of numbers
            int[] arrSorted = SortNumbers(arr2);
            Console.WriteLine(findMedian(arrSorted));

            // closest numbers
            Console.WriteLine("\n\nClosest numbers");
            int[] arr3 = { 5, 4, 3, 2 };
            Console.WriteLine("Original given array of numbers:");
            displayArray(arr3);                       // displaying given array of numbers
            if (arr3.Length <= 1)                     // validation - there should not be only 1 input, at least 2 inputs
                return;

            int[] sortedArray = SortNumbers(arr3);
            int[] r4 = closestNumbers(sortedArray);
            Console.WriteLine("\npair of elements that have the smallest absolute difference between them:");
            displayArray(r4);
            Console.ReadKey();

            // Day of programmer
            Console.WriteLine("\n\nDay of Programmer");
            int year = 2017;
            Console.WriteLine(dayOfProgrammer(year));
        }

        static void displayArray(int []arr) {       // method used to display content of array.
            Console.WriteLine();
            foreach(int n in arr) {
                Console.Write(n + " ");
            }
        }

        // Complete the rotLeft function below.
        static int[] rotLeft(int[] a, int d)
        {
            return new int[] {};
        }

        // Complete the maximumToys function below.
        static int maximumToys(int[] prices, int k)
        {
            return 0;
        }

        // Complete the balancedSums function below.
        static string balancedSums(List<int> arr)
        {
            return "";
        }

        // Complete the missingNumbers function below.
        static int[] missingNumbers(int[] arr, int[] brr)
        {
            return new int[] { };
        }


        // Complete the gradingStudents function below.
        static int[] gradingStudents(int[] grades)
        {
            try
            {
                for (int i = 0; i < grades.Length; i++)     // for loop used for iteration to get every number of array one by one
                {
                    if (grades[i] >= 38)    // checking if the number is greater than/equal to 38 because if the value of grade is less than 38, no rounding occurs because the result will still be a failing grade 
                    {
                        if ((5 - grades[i] % 5) < 3)        // checking whether the difference between the grade and the next multiple of 5 is less than 3
                        {
                            grades[i] = (grades[i] + (5 - grades[i] % 5));      // rounding off the number as per the given rule
                        }
                    }
                }
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Exception occured while computing gradingStudents()");
            }
            return grades;      // returning updated array which contains rounded off grades
        }

        // method for sorting array in ascending order
        static int[] SortNumbers(int[] arr)
        {
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        int tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }
            return arr;
        }

        // Complete the findMedian function below.
        static int findMedian(int[] arr)
        {
            decimal median = 0;
            int len = arr.Length;

            if (len % 2 == 0)
            {
                int num1 = arr[len / 2];
                int num2 = arr[(len / 2) - 1];
                median = (num1 + num2) / 2;
            }
            else
            {
                median = arr[(len) / 2];
            }
            Console.WriteLine("\nMedian of the given array of numbers is: {0}",median);
            Console.ReadKey();
            return 0;
        }

        // Complete the closestNumbers function below.
        static int[] closestNumbers(int[] arr)
        { 
            int min = arr[1] - arr[0];
            List<int> pairs = new List<int>();

            for (int i = 2; i< arr.Length-1; i++) // for getting the minimun difference among all the numbers
            {
                int diff = arr[i] - arr[i - 1];
                if (diff < min)
                    min = diff;
            }
            for (int i = 1; i< arr.Length; i++)
            {
                if ((arr[i] - arr[i - 1]) == min)
                {
                    pairs.Add(arr[i - 1]);
                    pairs.Add(arr[i]);
                }
            }
            Console.ReadKey();
            int[] pairsFinal = pairs.ToArray();
            return pairsFinal;
        }

        // Complete the dayOfProgrammer function below.
        static string dayOfProgrammer(int year)
        {
            return "";
        }
    }
}

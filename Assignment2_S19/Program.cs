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
            int[] grades = { 73, 67, 38, 33 };          
            int[] r3 = gradingStudents(grades);
            displayArray(r3);

            // find the median
            Console.WriteLine("\n\nFind the median");
            int[] arr2 = { 0, 1, 2, 4, 6, 5, 3};
            Console.WriteLine(findMedian(arr2));

            // closest numbers
            Console.WriteLine("\n\nClosest numbers");
            //int[] arr3 = { 5, 4, 3, 2 };
            int[] arr3 = { 6, -5, 15, 25, 71, 63 };
            int[] r4 = closestNumbers(arr3);
            displayArray(r4);            

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
            bool check = true;
            for (int j = 0; j < grades.Length; j++)     // for loop used for iteration and checking if all the numbers are between 0 to 100
            {
                if (grades[j] < 0 || grades[j] > 100) // checking validation - all the grades should be between 0 to 100
                {
                    check = false;
                }
            }

            if (check)      // in this block, if all the numbers are between 0 to 100 then we will call method and start applying the round off rules
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
            }
            else
            {
                Console.WriteLine("\nall the grades should be between 0 to 100.");
            }
            return grades;      // returning updated array which contains rounded off grades
        }

        // method for sorting array in ascending order
        static int[] SortNumbers(int[] arr)
        {
            for (int i = 0; i < arr.Length-1; i++)      // loop for iteration
            {
                for (int j = i + 1; j < arr.Length; j++)    // loop for comparing numbers and swapping
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
            int median = 0;
            try
            {
                arr = SortNumbers(arr);     // we will get the sorted array here.
                int len = arr.Length;

                if (arr == null || len == 0 || len % 2 == 0)    // corner case - checking if the array is not null or empty of having insufficient numbers
                {
                    Console.WriteLine("\nArray can not be empty or null or having even number of elements");
                }
                else
                {
                    median = arr[(len) / 2];        // getting the median of array
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing findMedian()");
            }
            Console.ReadKey();
            return median;
        }

        // Complete the closestNumbers function below.
        static int[] closestNumbers(int[] arr)
        {
            int[] pairsFinal;
            List<int> pairs = new List<int>();         // using list because we are not sure of array size
            if (arr.Length <= 1)                     // corner case - there should not be only 1 input, we need at least 2 inputs
            {
                Console.WriteLine("Provide at least 2 numbers");
            }
            else
            {
                arr = SortNumbers(arr);             // we will get the sorted array here
                int min = Math.Abs(arr[1] - arr[0]);    // getting the difference between first 2 elements while initialsing 'min' variable

                for (int i = 2; i < arr.Length ; i++) // this loop is for getting the minimun difference among all the numbers
                {
                    int diff = Math.Abs(arr[i] - arr[i - 1]);
                    if (diff < min)
                        min = diff;
                }
                for (int i = 1; i < arr.Length; i++)        // here we are looking for the pairs which have the minimum difference that we got in last loop.
                {
                    if ((Math.Abs(arr[i] - arr[i - 1])) == min)
                    {
                        pairs.Add(arr[i - 1]);                  // adding pairs to the list
                        pairs.Add(arr[i]);              
                    }
                }
            }
            pairsFinal = pairs.ToArray();           // converting list to array
            return pairsFinal;
        }

        // Complete the dayOfProgrammer function below.
        static string dayOfProgrammer(int year)
        {
            int RegularDays = 243;              // total regular days of month from january to august (non leap year)
            int ProgDays = 256;   
            int SeptDays = ProgDays - RegularDays;  // programming day in sept. month

            if(year>=1700 && year<=1917)    // for julian calender system
            {
                if(year%4==0)               // checking for leap year condition
                {
                    SeptDays = SeptDays - 1;
                }

            }
            if(year>1918)       // for gregorian calender system
            {
                if((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0)) // checking for leap year condition
                {
                    SeptDays = SeptDays - 1;
                }
            }
            if(year == 1918)        // for transition year
            {
                SeptDays = SeptDays + 14;
            }
            Console.WriteLine(SeptDays + ".09." + year);
            Console.ReadKey();
            return "";
        }
    }
}

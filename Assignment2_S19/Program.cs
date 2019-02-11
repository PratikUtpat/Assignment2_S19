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
            List<int> arr = new List<int> { 2,0,0 };
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
            int[] arr2 = { 0, 1, 2, 4, 6, 5, 3 };
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
            Console.ReadKey();
        }

        static void displayArray(int[] arr) {       // method used to display content of array.
            Console.WriteLine();
            foreach (int n in arr) {
                Console.Write(n + " ");
            }
        }

        // Complete the rotLeft function below.
        static int[] rotLeft(int[] a, int d)
        {
                int[] b = new int[a.Length]; // Here we created a new array i.e. b equal to the length of array a.

                int n; // here we create an n variable so that we can apply our logic through index of an array
                int length = a.Length; // Here we created length variable which is equal to the length of array a.
                int place; // here we create a place variable.


                for (int i = 0; i < length; i++) // Here we applied a for loop in which i declare a variable i and this loop will be on for 5 times as i should be less than length variable which is equal to the length of an array a.
                {
                    n = i - d; // Here we started buiding our left shift rotation logic. In this line we are selecting the index of elements present in an array a. 
                    place = length + n; // Here we are selecting the index of an element which needs to be moved.
                    if (n >= 0) // here we applied if loop to decide the position of the selected element on the basis of index . If the index is greater than or equal to 0 then the element will enter the loop and added to the new array b.
                    {
                        b[n] = a[i]; // if element's index satisfies the condition then it will add to an array b and the element of array a present at i index will move to the array b[index].
                    }
                    else // if the element's index doesn't satisfy the above condition will fall to else statement
                    {
                        b[place] = a[i]; // now the element will be placed according to the index
                    }
                }

                return b; // return array b
     
        }

        // Complete the maximumToys function below.
        static int[] sortArr(int[] arr) // We are sorting our array through this general algorithm of sorting.
        {
            int mini; // Here we create a minimum

            int n; // here we declare integer n which help me to complete my indexing logic

            for (int i = 0; i < arr.Length; i++)
            {
                mini = i; // Here we set our mini variable to index of an array
                // From the min_position, check to see if the next element is smaller
                for (int x = i + 1; x < arr.Length; x++) // here we apply for loop in which we declare integer x and assign it to the i+1 (It means we are taking next element with i index) and condition is x should be less than length of array. 
                {
                    if (arr[x] < arr[mini]) // If the next element is smaller than my mini variable, then make it my mini variable
                    {
                        mini = x; //mini will keep track of the index, this is needed when exchange will take place
                    }
                }

                // If the min_po does not equal the current element being evaluated in the loop
                // Then execute the swap. by switching the postion of the lowest with the current element
                if (mini != i) // It will check my mini variable if it is not equal to i then it will enter the loop
                {
                    n = arr[i]; // Here we used our declared variable n and we assign to array element present at i index
                    arr[i] = arr[mini]; // Now they will exchenge their position of lowest mini with index i
                    arr[mini] = n; // And assigning it to the n variable. This is how we exchange if element of index i is greater than mini
                }
            }
            return arr; // returning array
        }

        static int maximumToys(int[] prices, int k)

        {

            int[] sorted = sortArr(prices); // Here we sort our price array through our defined sort method
            int sum = 0, i; // Declare two integers sum which is equal to 0 and i
            for (i = 0; i < sorted.Length; i++) // Here we applied for loop. In whic we declare an integer i equal to 0 and applied a condition in which i should be less than length of sorted array. Untill this condition breaks the loop wiil execute.
            {
                if (sum < k) // here we applied if loop. According to this loop if sum is less than k (which is nothing but the amount the person willing to spend) and if it satify it enters this loop.
                {
                    sum += sorted[i]; // So according to this elements present i index will add to integer sum
                }
                else // If the sum is greater than k then it will enter else 
                {
                    break; // it will break
                }
            }

            return i - 1;
        }


        // Complete the balancedSums function below.
        static string balancedSums(List<int> arr)
        {
            int n = arr.Count; // here we create integer n and assigning it to length of the array (arr.Count will count total elements in an array)
            int rSum = 0; // Declare a integer sum which set 0
            int lSum = 0; // declare an integer lsum set to 0 as the element is at index 0
            for (int i = 0; i < n; ++i) // (To comput rigth sum)here we applied for loop in which we declare integer i set to 0 and also applied a condition which is i should be less than n(i.e. length of array) 
                rSum += arr[i]; //

            for (int i = 0; i < i + 1; ++i) //(Checking a point where lSum==rSum) We applied for loop here and applied a condition that i should be less than i+1 . if it satisfy the condition enter the loop
            {

                lSum += arr[i]; // Sum for left at index i 
                rSum -= arr[i + 1]; // Sum for right at index i+1
                if (lSum == rSum) // if loop applied inside for loop to provide a specific condition which checks leftsum (lSum) is equal to rightsum(rSum)
                    return "Yes"; // if it does then print yes                
            }
            return "No"; // and if it doesnot then return no
        }

        // Complete the missingNumbers function below.
        static int[] missingNumbers(int[] arr, int[] brr)
        {
            int i = 0; // created an integer i and set the value of i=0
            int j = 0; // created an another interger j and set it 0
            int n = 0; // created an another interger k and set it 0
            int curr; // created an another interger curr
            int miss; // created an another interger miss

            arr = sortArr(arr); // As the sortArr is already build above. so we used that function to sort the array arr
            brr = sortArr(brr); // Same sortArr method is also applied here to sort array brr
            int[] c = new int[brr.Length]; // Here we created a new array c which is equal to the lenght of array brr
            while (i < brr.Length) // Here we applied while loop. This loop ends when this condition (i<brr.Lenght) breaks. It means when i is greater than brr.Length 
            {
                curr = arr[i]; // here we track the current value of array
                while (j < arr.Length) // while loop is applied here inside while loop. Now this loop will continue untill it breaks the condition for j which should be less than arr.length.
                {
                    if (brr[i] == arr[j]) // If statement is applied here. It checks the value in brr array at i position is equal to the value of array arr at i position
                    {
                        i++; // If the condition satisfy i will keep on increasing and outter loop will keep going on
                        j++; // If the condition satisfy j will keep on increasing and inner loop will keep going on
                    }
                    else // If it doesnot satisfy the above If statement then it will fall to else.
                    {
                        miss = brr[i];
                        Console.WriteLine(miss); // here we are printing out the missing value
                        n++; // now integer n will keep on increasing
                        i++; // now the first value of i checked and cannot exit the loop untill i exceeds brr.Length 
                    }
                }
            }
            return new int[] { };
        }


        // Complete the gradingStudents function below.
        static int[] gradingStudents(int[] grades)
        {
            try
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
            for (int i = 0; i < arr.Length - 1; i++)      // loop for iteration
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
            try
            {
                if (arr == null || arr.Length <= 1)                     // corner case - there should not be only 1 input, we need at least 2 inputs
                {
                    Console.WriteLine("Provide at least 2 numbers");
                }
                else
                {
                    arr = SortNumbers(arr);             // we will get the sorted array here
                    int min = Math.Abs(arr[1] - arr[0]);    // getting the difference between first 2 elements while initialsing 'min' variable

                    for (int i = 2; i < arr.Length; i++) // this loop is for getting the minimun difference among all the numbers
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
            }
            catch
            {
                Console.WriteLine("Exception occured while computing closestNumbers()");
            }
            pairsFinal = pairs.ToArray();           // converting list to array
            return pairsFinal;
        }

        // Complete the dayOfProgrammer function below.
        static string dayOfProgrammer(int year)
        {
            try
            {
                int RegularDays = 243;              // total regular days of month from january to august (non leap year)
                int ProgDays = 256;
                int SeptDays = ProgDays - RegularDays;  // programming day in sept. month

                if (year >= 1700 && year <= 1917)    // for julian calender system
                {
                    if (year % 4 == 0)               // checking for leap year condition
                    {
                        SeptDays = SeptDays - 1;
                    }

                }
                if (year > 1918)       // for gregorian calender system
                {
                    if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0)) // checking for leap year condition
                    {
                        SeptDays = SeptDays - 1;
                    }
                }
                if (year == 1918)        // for transition year
                {
                    SeptDays = SeptDays + 14;
                }
                return SeptDays + ".09." + year;
            }

            catch
            {
                Console.WriteLine("Exception occured while computing closestNumbers()");
            }
            return "";
        }
    }
    }

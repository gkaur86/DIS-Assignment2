using System;
using System.Collections.Generic;
using System.Linq;
namespace Assignment2_DIS_Spring2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question1:
            Console.WriteLine("Question 1");
            int[] ar1 = { 2, 5, 1, 3, 4, 7 };
            int n1 = 3;
            ShuffleArray(ar1, n1);
            Console.WriteLine();

            //Question 2 
            Console.WriteLine("Question 2");
            int[] ar2 = {0,1,0,3,12};
            MoveZeroes(ar2);
            Console.WriteLine("");

            //Question3
            Console.WriteLine("Question 3");
            int[] ar3 = { 1, 2, 3, 1, 1, 3 };
            CoolPairs(ar3);
            Console.WriteLine();

            //Question 4
            Console.WriteLine("Question 4");
            int[] ar4 = { 2, 7, 11, 15 };
            int target = 9;
            TwoSum(ar4, target);
            Console.WriteLine();

            //Question 5
            Console.WriteLine("Question 5");
            string s5 = "korfsucy";
            int[] indices = { 6, 4, 3, 2, 1, 0, 5, 7 };
            RestoreString(s5, indices);
            Console.WriteLine();

            //Question 6
            Console.WriteLine("Question 6");
            string s61 = "bulls";
            string s62 = "sunny";
            if(Isomorphic(s61,s62))
            {
                Console.WriteLine("Yes the two strings are Isomorphic");
            }
            else
            {
                Console.WriteLine("No, the given strings are not Isomorphic");
            }
            Console.WriteLine();

            //Question 7
            Console.WriteLine("Question 7");
            int[,] scores = { { 1, 91 }, { 1, 92 }, { 2, 93 }, { 2, 97 }, { 1, 60 }, { 2, 77 }, { 1, 65 }, { 1, 87 }, { 1, 100 }, { 2, 100 }, { 2, 76 } };
            HighFive(scores);
            Console.WriteLine();

            //Question 8
            Console.WriteLine("Question 8");
            int n8 = 19;
            if(HappyNumber(n8))
            {
                Console.WriteLine("{0} is a happy number",n8);
            }
            else
            {
                Console.WriteLine("{0} is not a happy number", n8);
            }

            Console.WriteLine();

            //Question 9
            Console.WriteLine("Question 9");
            int[] ar9 = { 7, 1, 5, 3, 6, 4 };
            int profit = Stocks(ar9);
            if(profit == 0)
            {
                Console.WriteLine("No Profit is possible");
            }
            else
            {
                Console.WriteLine("Profit is {0}",profit);
            }
            Console.WriteLine();

            //Question 10
            Console.WriteLine("Question 10");
            int n10 = 3;
            Stairs(n10);
            Console.WriteLine();
        }

        //Question 1
        /// <summary>
        /// Shuffle the input array nums consisting of 2n elements in the form [x1,x2,...,xn,y1,y2,...,yn].
        /// Print the array in the form[x1, y1, x2, y2, ..., xn, yn].
        ///Example 1:
        ///Input: nums = [2,5,1,3,4,7], n = 3
        ///Output: [2,3,5,4,1,7]
        ///  Explanation: Since x1 = 2, x2 = 5, x3 = 1, y1 = 3, y2 = 4, y3 = 7 then the answer is [2,3,5,4,1,7].
        ///Example 2:
        ///Input: nums = [1,2,3,4,4,3,2,1], n = 4
        ///Output: [1,4,2,3,3,2,4,1]
        ///Example 3:
        ///Input: nums = [1,1,2,2], n = 2
        ///Output: [1,2,1,2]
        /// </summary>

        private static void ShuffleArray(int[] nums, int n)
        {
            try
            {
                if (nums.Length == 0 || nums.Length != 2*n) // Edge case if empty list is passed. 
                {
                    Console.WriteLine("Error need atleast 1 element OR number of elements is not equal to 2n");
                }
                else
                {
                    //write your code here.
                    int[] result = new int[nums.Length];   // Result Array of length 2n

                    for (int i = 0; i < n; i++)   // Pupulate every even number
                    {
                        result[i * 2] = nums[i];
                    }

                    for (int j = 1; j < n + 1; j++)  //Populare odd numbers
                    {
                        result[(j * 2) - 1] = nums[n + j - 1];
                    }

                    //Print the array

                    Console.Write("[");
                    for (int i = 0; i < result.Length; i++)
                    {
                        Console.Write(result[i]);
                        if(i<result.Length-1)
                            Console.Write(",");

                    }
                    Console.Write("]");
                }
            }

            //Reflection: I was able to do it in O(2n). The main driving point was to populate odd and even located inigers seperatly. 
            catch (Exception)
            {

                throw;
            }
        }

        //Question 2:
        /// <summary>
        /// Write a method to move all 0's to the end of the given array. You should maintain the relative order of the non-zero elements. 
        /// You must do this in-place without making a copy of the array.
       /// Example:
       ///Input: [0,1,0,3,12]
       /// Output: [1,3,12,0,0]
       /// </summary>
       
        private static void MoveZeroes(int[] ar2)
        {
            try
            {

                if (ar2.Length == 0) // Edge case if empty list is passed. 
                {
                    Console.WriteLine("Error need atleast 1 element");
                }
                else
                {
                    //write your code here.
                    int j = 0;     // Keep track of how many non-zero elements
                    int z = 0;     //keep track of how many zeros

                    for (int i = 0; i < ar2.Length; i++)  // loop though the array 
                    { 
                        if (ar2[i] != 0)    //check if element is not zero
                        {
                            ar2[j] = ar2[i]; //Push the non-zero elements
                            j++;               
                        }
                        else
                        {
                            z++;    //track if zero
                        }
                    }
                    for (int i = 0; i < z; i++) // loop for all zero elements
                        ar2[j + i] = 0;      // push zeros to array

                    //print the array
                    Console.Write("[");
                    for (int i = 0; i < ar2.Length; i++)
                    {
                        Console.Write(ar2[i] + ",");
                    }
                    Console.Write("]");
                }

            }


            // Reflection : This was one of the simple questions of the assignment. We just had to keep track of the zeros and push the non zero. 
            catch (Exception)
            {

                throw;
            }
        }
        

        //Question 3
        /// <summary>
        /// For an array of integers - nums
        ///A pair(i, j) is called cool if nums[i] == nums[j] and i<j
        ///Print the number of cool pairs
        ///Example 1
        ///Input: nums = [1,2,3,1,1,3]
        ///Output: 4
        ///Explanation: There are 4 cool pairs (0,3), (0,4), (3,4), (2,5) 
        ///Example 3:
        ///Input: nums = [1, 2, 3]
        ///Output: 0
        ///Constraints: time complexity should be O(n).
        /// </summary>

        private static void CoolPairs(int[] nums)
        {
            try
            {

                if (nums.Length < 2) // Edge case if empty list is passed. 
                {
                    Console.WriteLine("Error, need atleast 2 elements");
                }
                else
                {
                    int count = 0;    // count the cool numbers
                    //write your code here.
                    Dictionary<int, int> track = new Dictionary<int, int>();  // Dictionary to keep track of the numbers

                    for (int i = 0; i < nums.Length; i++) // loop
                    {
                        if (track.ContainsKey(nums[i]))  //check if number is in dictionary
                        {
                            count += track[nums[i]];  // if number found add it to count
                            track[nums[i]]++;       // increase it coolness
                        }

                        else
                        {
                            track.Add(nums[i], 1);  // add number to dictionary with coolness of 1
                        }
                    }
                    Console.WriteLine(count);   
                }
            }


            // Reflection: Initially I did it in O(n^2) by having 2 nested loops. To solve it in O(n) I again had to use a dictionary to keep track of the numbers seen.
            catch (Exception)
            {

                throw;
            }
        }

        //Question 4:
        /// <summary>
        /// Given integer target and an array of integers, print indices of the two numbers such that they add up to the target.
        ///You may assume that each input would have exactly one solution, and you may not use the same element twice.
        /// You can print the answer in any order
        ///Example 1:
        ///Input: nums = [2,7,11,15], target = 9
        /// Output: [0,1]
        ///Output: Because nums[0] + nums[1] == 9, we print [0, 1].
        ///Example 2:
        ///Input: nums = [3,2,4], target = 6
        ///Output: [1,2]
        ///Example 3:
        ///Input: nums = [3,3], target = 6
        ///Output: [0,1]
        ///Constraints: Time complexity should be O(n)
        /// </summary>
        private static void TwoSum(int[] nums, int target)
        {
            try
            {
                //write your code here.

                if (nums.Length == 0) // Edge case if empty list is passed. 
                {
                    Console.WriteLine("Error, need atleast 1 element");
                }
                else
                {

                    Dictionary<int, int> ts = new Dictionary<int, int>(); // Dictionary to keep track of numbers and the differences.

                    for (int i = 0; i < nums.Length; i++)
                    {
                        int dif = target - nums[i]; // Calculate the difference between target and current number
                        if (ts.ContainsKey(dif))    // if difference is there in dictionary 
                        {

                            Console.WriteLine("[" + ts[dif] + "," + i + "]"); // print the result
                            break;  // Break the loop as there is only 1 result
                        }
                        else
                        {
                            ts.Add(nums[i], i);  // add the number and index. 
                        }
                    }
                }

                // Reflection: The challenge was to solve it in O(n). The solution was keep track of index of number and if we find that difference between target and current number is in dictionary.

            }
            catch (Exception)
            {

                throw;
            }

        }

        //Question 5:
        /// <summary>
        /// Given a string s and an integer array indices of the same length.
        ///The string s will be shuffled such that the character at the ith position moves to indices[i] in the shuffled string.
        ///Print the shuffled string.
        ///Example 1
        ///Input: s = "korfsucy", indices = [6,4,3,2,1,0,5,7]
        ///Output: "usfrocky"
        ///Explanation: As shown in the assignment document, “K” should be at index 6, “O” should be at index 4 and so on. “korfsucy” becomes “usfrocky”
        ///Example 2:
        ///Input: s = "USF", indices = [0,1,2]
        ///Output: "USF"
        ///Explanation: After shuffling, each character remains in its position.
        ///Example 3:
        ///Input: s = "ockry", indices = [1, 2, 3, 0, 4]
        ///Output: "rocky"
        /// </summary>
        private static void RestoreString(string s, int[] indices)
        {
            try
            {
                //write your code here.
                if (s.Length != indices.Length) // check if lenght of string and array is same
                {
                    Console.WriteLine("Error. Indices array and string of different length");
                }
                else
                {

                    char[] str = new char[indices.Length];  // empty character array of length of string
                    for (int i = 0; i < indices.Length; i++)    // iterate over the indices array
                    {
                        str[indices[i]] = s.ElementAt(i);  // store character at the given index
                    }
                    Console.WriteLine(new String(str));  // convert the character array to string and console write
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        // Reflections:  The datastructure was the main thing to see. Logic of converting array of characters to string. 


        //Question 6
        /// <summary>
        /// Determine whether two give strings s1 and s2, are isomorphic.
        ///Two strings are isomorphic if the characters in s1 can be replaced to get s2.
        ///All occurrences of a character must be replaced with another character while preserving the order of characters.
        ///No two characters may map to the same character but a character may map to itself.
        ///Example 1:
        ///Input:s1 = “bulls” s2 = “sunny” 
        ///Output : True
        ///Explanation: ‘b’ can be replaced with ‘s’ and similarly ‘u’ with ‘u’, ‘l’ with ‘n’ and ‘s’ with ‘y’.
        ///Example 2:
        ///Input: s1 = “usf” s2 = “add”
        ///Output : False
        ///Explanation: ‘u’ can be replaced with ‘a’, but ‘s’ and ‘f’ should be replaced with ‘d’ to produce s2, which is not possible. So False.
        ///Example 3:
        ///Input : s1 = “ab” s2 = “aa”
        ///Output: False
        /// </summary>
        private static bool Isomorphic(string s1, string s2)
        {
            try
            {
                //write your code here.

                if (s1.Length!=s2.Length) // Edge case. If lengths of 2 strings are not equal
                return false;

                Dictionary<char, char> dict = new Dictionary<char, char>(); // initialize dictionary to keep track of characters


                for (int i=0; i<s1.Length; i++)    // Loop through the strings
                {
                    if (dict.ContainsKey(s1[i]))   // check if character is dictionary
                    {
                        if (dict[s1[i]] != s2[i])   // Is the character coded same as the code in dictionary
                        {
                            return false;
                        }
                    }
                    else
                    {
                        dict.Add(s1[i], s2[i]);  // If character not in dictionary. Add the character and what it is coded as.
                    }
                }


                return true;
            }

            /// Reflection : The key was keeping a Dictionary keeping track of what character is coded as which character. 
            catch (Exception)
            {

                throw;
            }
        }

        //Question 7
        /// <summary>
        /// Given a list of the scores of different students, items, where items[i] = [IDi, scorei] represents one score from a student with IDi, calculate each student's top five average.
        /// Print the answer as an array of pairs result, where result[j] = [IDj, topFiveAveragej] represents the student with IDj and their top five average.Sort result by IDj in increasing order.
        /// A student's top five average is calculated by taking the sum of their top five scores and dividing it by 5 using integer division.
        /// Example 1:
        /// Input: items = [[1, 91], [1,92], [2,93], [2,97], [1,60], [2,77], [1,65], [1,87], [1,100], [2,100], [2,76]]
        /// Output: [[1,87],[2,88]]
        /// Explanation: 
        /// The student with ID = 1 got scores 91, 92, 60, 65, 87, and 100. Their top five average is (100 + 92 + 91 + 87 + 65) / 5 = 87.
        /// The student with ID = 2 got scores 93, 97, 77, 100, and 76. Their top five average is (100 + 97 + 93 + 77 + 76) / 5 = 88.6, but with integer division their average converts to 88.
        /// Example 2:
        /// Input: items = [[1,100],[7,100],[1,100],[7,100],[1,100],[7,100],[1,100],[7,100],[1,100],[7,100]]
        /// Output: [[1,100],[7,100]]
        /// Constraints:
        /// 1 <= items.length <= 1000
        /// items[i].length == 2
        /// 1 <= IDi <= 1000
        /// 0 <= scorei <= 100
        /// For each IDi, there will be at least five scores.
        /// </summary>
        private static void HighFive(int[,] items)
        {
            try
            {
                //write your code here.

                Dictionary<int, List<int>> Store = new Dictionary<int, List<int>>(); // Dictionary to keep track of students and their scores. Ref reflections

                for (int i=0; i< items.Length/2; i++) // loop through all the students
                {

                if (Store.ContainsKey(items[i, 0])) // check if subject in dictionary
                    {
                        Store[items[i, 0]].Add(items[i, 1]); // if student in dictionary add this score
                    }
                    else // else (if subject not in dictionary)
                    {
                        List<int> gg = new List<int>(); // initialise an empty list
                        gg.Add(items[i, 1]); // add score to list
                        Store.Add(items[i, 0], new List<int>(gg)); // add student and new list to dictionary 
                    }
                }

                // starting output
                Console.Write("[");
                for (int i=0; i<Store.Count; i++)
                {
                    int ke = Store.ElementAt(i).Key; // get student
                    int[] aa = Store[ke].ToArray(); // get marks of student
                    Array.Sort(aa); //Sort the array
                    Array.Reverse(aa);  // reverse the sorted array


                    if (aa.Length < 5) // check if the student has marks for 5 subjects (edge case)
                    {
                        Console.Write("[" + ke + "," + "Student does not have 5 subjects" + "]");
                    }
                    else
                    {
                        int sum = 0;  // initialize sum for student 

                        for (int j = 0; j < 5; j++)
                        {
                            sum = sum + aa[j];   // calculate sum of top 5 subject of students 
                        }
                        Console.Write("[" + ke + "," + sum / 5 + "]"); // print it the student and the average
                    }
                }
                Console.Write("]");


               //Reflection: Datastructure to be used in this question was major thing. I used a Dictionry which had student as the key and marks the student got in the list
               // Edge case which I could see was if less than 5 subjects are given for a student (even though question says at least 5) 

            }
           catch (Exception)
           {

                throw;
           }
        }

        //Question 8
        /// <summary>
        /// Write an algorithm to determine if a number n is happy.
        ///A happy number is a number defined by the following process:
        ///•	Starting with any positive integer, replace the number by the sum of the squares of its digits.
        ///•	Repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1.
        ///•	Those numbers for which this process ends in 1 are happy.
        ///Return true if n is a happy number, and false if not.
        ///Example 1:
        ///Input: n = 19
        ///Output: true
        ///Explanation:
        ///12 + 92 = 82
        ///82 + 22 = 68
        ///62 + 82 = 100
        ///12 + 02 + 02 = 1
        ///Example 2:
        ///Input: n = 2
        ///Output: false
        ///Constraints:
        ///1 <= n <= 231 - 1
        /// </summary>

        private static bool HappyNumber(int n)
        {
            try
            {

                if (n < 0) // edge case if negative number is passed. 
                {
                    return false;
                }

                List<int> vistited = new List<int>();

                while (n != 0)  // Loop till there is a number
                {

                    n = sumsquares(n); // Call the helper function to calculate sum of square of all digits

                    if (n == 1)         // Case 1: if sum of square is 1
                        return true;

                    if (vistited.Contains(n))  // Has this number been seen before
                    {
                        return false;          // if it has been seen return true as we will go in loop. 

                    } else
                    {
                        vistited.Add(n);        // if the number is not see add to list 
                    }



                }
                return false;          // Return false for edge cases

            }

        
            catch (Exception)
            {

                throw;
            }
        }



        // Helper function to calculate the sum of square all digits of a number
        public static int sumsquares(int n)
        {

            int sq = 0;     //intialize the square sum 
            while (n != 0)
            {
                sq = sq + Convert.ToInt32(Math.Pow(n % 10, 2));  // add square of digit to bymber
                n = n / 10;   // got 1 digit back. 


            }
            return sq;   // return the sum 
        }


        // Reflection:  There was 2 issues here. 1. What to do if we come to the same number again what will happen. 2. Keep calculating sum of square of digits recursively.
        // The solution was to have a list and keep track of all the numbers seen and to make a helper function which can be called recursively to calculate sum of square of digits.



        //Question 9
        /// <summary>
        /// Professor Manish is planning to invest in stocks. He has the data of the price of a stock for the next n days.  
        /// Tell him the maximum profit he can earn from the given stock prices.Choose a single day to buy a stock and choose another day in the future to sell the stock for a profit
        /// If you cannot achieve any profit return 0.
        /// Example 1:
        /// Input: prices = [7,1,5,3,6,4]
        /// Output: 5
        /// Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
        /// Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
        /// Example 2:
        /// Input: prices = [7,6,4,3,1]
        /// Output: 0
        ///Explanation: In this case, no transactions are done and the max profit = 0.
        ///Try to solve it in O(n) time complexity.
        /// </summary>

        private static int Stocks(int[] prices)
        {
            try
            {
                int minp = int.MaxValue;  // Define variable to keep track of min Price. Defining it as max int value. 
                int maxp = 0;             // Variable to keep track of max profit

                // Loop through the prices
                for (int i = 0; i < prices.Length; i++)
                {
                    if (prices[i] < minp)    // keep track of min price
                        minp = prices[i];
                    else if (prices[i] - minp > maxp)  // calculate profit
                        maxp = prices[i] - minp;      // track of max profit
                }
                return maxp;

            }

            // Reflection: Noting that the array is a time array, that is, to find the best buying point and selling point was the key. 
            catch (Exception)
            {

                throw;
            }
        }



        //Question 10
        /// <summary>
        /// Professor Clinton is climbing the stairs in the Muma College of Business. He generally takes one or two steps at a time.
        /// One day he came across an idea and wanted to find the total number of unique ways that he can climb the stairs. Help Professor Clinton.
        /// Print the number of unique ways. 
        /// Example 1:
        ///Input: n = 2
        ///Output: 2
        ///Explanation: There are two ways to climb to the top.
        ///1. 1 step + 1 step
        ///2. 2 steps
        ///Example 2:
        ///Input: n = 3
        ///Output: 3
        ///Explanation: There are three ways to climb to the top.
        ///1. 1 step + 1 step + 1 step
        ///2. 1 step + 2 steps
        ///3. 2 steps + 1 step
        ///Hint : Use the concept of Fibonacci series.
        /// </summary>

        private static void Stairs(int steps)
        {
            try
            {
                //write your code here.

                // Handling edge cases
                if (steps <= 0)
                    Console.WriteLine("Need at least 1 step");
                if (steps == 1)
                    Console.WriteLine(1);

                // Getting to main code. 
                if (steps > 1)
                {



                    int first = 1;  // define variable 
                    int second = 2; // define variable 
                    for (int i = 3; i <= steps; i++)
                    {
                        int third = first + second; // calculate number of ways for the step i
                        first = second;             // store values for next step 
                        second = third;
                    }
                    Console.WriteLine(second);
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        // Reflection: Figuring out the logic to calculate the fibonacci number was tricky. Once I figured out that the number repeat and add, it was simpler.
        //Also figuring out the right edge cases. 
    }
}

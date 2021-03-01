using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment2_DIS_Spring2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question1
            int[] ar1 = { 2, 5, 1, 3, 4, 7 };
            int n1 = 3;
            ShuffleArray(ar1, n1);

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
            
            //n = 3
            int[] numbers = {2, 5, 1, 3, 4, 7 };

            //index elements of the above array in order to manipualte positions.
            int a = numbers[0];            
            int b = numbers[1];
            int c = numbers[2];
            int d = numbers[3];
            int e = numbers[4];
            int f = numbers[5];

            //group the elements of x1 y1, x2 y2, and x3 y3 together into an array in order to create new n3 ordered array.
            int[] x1 = { a, d };
            int[] x2 = { b, e };
            int[] x3 = { c, f };


            /*foreach (int element in x1)
            {
                Console.WriteLine(element);
            }
            foreach (int element in x2)
            {
                Console.WriteLine(element);
            }
            foreach(int element in x3)
            {
                Console.WriteLine(element);
            }
            */

            //merge all grouped arrays into one list. 
            var list = new List<int>();
            list.AddRange(x1);
            list.AddRange(x2);
            list.AddRange(x3);

            //convert merged list back into an array for printing through a foreach statement.
            int[] z = list.ToArray();

            foreach (int element in z)
            {
                Console.WriteLine(element);
            }
            

            //Self Reflection:
            //had a good opportunity to work with array indexes and learned how to concatenate several arrays into one list for printing.



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
                //write your code here.
                
                int[] arr = {0,1,0,3,12};

                int i, count = 0;

                int n = 5;

                //traverse the array
                for (i = 0; i < n; i++)
                {
                    if (arr[i] > 0)
                    {
                        arr[count++] = arr[i];
                    }
                }

                //push zero elements to the end
                while (count < n)
                {
                    arr[count++] = 0;
                }

                //print output array
                for (i=0; i<n; i++)
                {
                    Console.WriteLine(arr[i]);
                }


                //Self Reflection:
                  //This exercise helped me experience again the power and creative use of the for loop statement in combination with the 
                   //while loop to manipulate array elements.


            }
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

                //array of numbers to work with:
                int[] array = { 1, 2, 3, 1, 1, 3 };

                
                Array.Sort(nums);
                int count = 0;
                int i = 0;

                //interation of array index[j] relative to array index[i]
                for(int j=1; j < nums.Length; j++)
                {
                    if (nums[j] == nums[i])
                        count += j - i;
                    else i = j;
                }

                //returns the count of paired numbers that are equal, yet where i<j  
                Console.WriteLine($"number of cool pairs is: {count}");


                //Self Reflection:
                  //I learned a new creative way of how to sort elemets of an array through the use of for loops and if statements which i had 
                   //never thought of.


            }
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
                
                int[] numbers = { 2, 7, 11, 15 };
                int targ = 9;
                               
                //create for loop with indice i to run through entire array 'numbers' 
                for (int i=0; i < numbers.Length; i++)
                {    
                    
                    //create nested for loop with indice j to run through entire array 'numbers' relative to indice i
                    for (int j = i; j < numbers.Length; j++)            
                    
                    //though the nested for loop iteration processs, if the sum indices i and j equals to target (9) then print.  
                    if (numbers[i] + numbers[j] == targ)
 
                            Console.WriteLine($"the array indices that add up to the integer target are: {i},{j}");                   
                }


                //Self Reflection: This exercise is making me start realizing the creative uses of nested for loop statements which have
                  //the ability to help me me find pattens or hidden results within combination of numbers within an array. 

                 

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

                int[] sequence = {6,4,3,2,1,0,5,7};
                string word= "korfsucy";


                //creating an array named str, which will represent the characters of the word array and equate it to the 
                 //length of the sequence array
                char[] str = new char[sequence.Length];


                //initializing a for loop to go through the sequence array 
                for (int i = 0; i < sequence.Length; i++)
                {

                    //once the sequence array for loop has been iterated, it will converge the indices of the array that have
                     //equal values
                    str[sequence[i]] = (str[i]);


                    //print the str array in the new order
                    Console.WriteLine(str);

                }



                //Self Reflection: I worked on this problem about 2.5 hours, I attempted the logic as best I could, but am still
                 //not able to get the approptiate output. I Feel that what i'm missing is minor but im not able to spot it.


            }



            catch (Exception)
            {

                throw;
            }

        }






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


        private static bool Isomorphic(string str1, string str2)
        {
            try
            {

                    int m = str1.Length;
                    int n = str2.Length;

                    // Length of both strings must be same  
                     // for one to one corresponance 
                    if (m != n)
                    Console.WriteLine("false"); 


                    // To mark visited characters in str2 
                    bool[] marked = new bool[str2.Length];

                    for (int i = 0; i < str2.Length; i++)
                        marked[i] = false;


                    // To store mapping of every character 
                     // from str1 to that of str2 and 
                      // Initialize all entries of map as -1. 
                    int[] map = new int[str1.Length];

                    for (int i = 0; i < str1.Length; i++)
                        map[i] = -1;

                    // Process all characters one by on 
                    for (int i = 0; i < n; i++)
                    {

                        // If current character of str1 is  
                         // seen first time in it. 
                        if (map[str1[i]] == -1)
                        {

                            // If current character of str2 
                             // is already seen, one to 
                              // one mapping not possible 
                            if (marked[str2[i]] == true)
                            Console.WriteLine("false");

                          // Mark current character of  
                           // str2 as visited 
                          marked[str2[i]] = true;

                            // Store mapping of current characters 
                            map[str1[i]] = str2[i];
                        }

                        // If this is not first appearance of current 
                         // character in str1, then check if previous 
                          // appearance mapped to same character of str2 
                        else if (map[str1[i]] != str2[i])

                            Console.WriteLine("false");
                    }

                        
                    Console.WriteLine("true");



                //Self Reflection: I worked on this problem for about 3 hours and went through the logic as best I could,
                 //but i honesty dont completly understand how to get the appropriate output. Im stil confused as to how to 
                  //translate this question into code.

            }


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

                
            }


            catch (Exception)
            {

                throw;
            }


            //Self Reflection:  Im not even sure where to begin with this question..
             //beyond my current level of programming understanding, I aspire to one day be able to take on this type of challenge.


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
                int n8 = 19;


                int squareSum = 0;
                    while (n != 0)
                    {
                        squareSum += (n8 % 10) *
                                     (n8 % 10);
                        n8 /= 10;
                    }
                    Console.WriteLine(squareSum);
                

                // method return true if 
                 // n is Happy number 
                  
                {
                    int slow, fast;

                    // initialize slow and 
                     // fast by n8 
                    slow = fast = n8;
                    do
                    {

                        // move slow number 
                         // by one iteration 
                        slow = numSquareSum(slow);

                        // move fast number 
                         // by two iteration 
                        fast = numSquareSum(numSquareSum(fast));

                    }

                    while (slow != fast);

                    // if both number meet at 1, 
                     // then return true 
                   Console.WriteLine(slow == 1);

                }


                return false;



                //Self Reflection: I worked on this problem for about 3 hours, i tried the logic as best I could,
                 //but as a beginner with no previous experience in programming, these last couple of problems just proved
                  //to be to difficult and beyond my current comprehension. Though I must admit that the hours spent 
                   //struggling with these exercises have been useful and made me more knowledgable and aware of the 
                    //C# languange and programming overall. As useful as this experience has been for me, I just hope 
                     //its enough to impress the professor to not give me a bad grade, given all ive learned so far. 



            }
            catch (Exception)
            
            {

                throw;
            }
        }



        private static int numSquareSum(int slow)
        {
            throw new NotImplementedException();
        }






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


                int[] ar9 = { 7, 1, 5, 3, 6, 4 };
            
                //assign variables for lowest and highest price for stock
                int lowestprice = ar9[0];
                int highestprice = ar9[1];


                //iterate array with for loop in attempt to isolate lowestprice 
                for (int i = 0; i < ar9.Length; i++)

                {
                    if (ar9[i] < lowestprice)

                        lowestprice = ar9[i];

                }

                //iterate array with for loop in attempt to isolate highestprice which comes after the lowest price array indice
                for (int j = 1; j < ar9.Length; j++)

                {
                    if (ar9[j] > highestprice)

                        highestprice = ar9[j];
                }


                int maxprofit = (highestprice - lowestprice);

                Console.WriteLine(maxprofit);



                //Self Reflection: This was an interesting question, giving me furthur experience on how to 
                 //manipulate elements of an array, as well as how to sort through arrays with more than one
                  //for loop in order to isoalte multiple values.



                return 0;
            }
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
               
                //number of combinations to climb to the top
                int n10 = 3;   
                
                
                //Need to decrement by 1 since we are starting from 0
                int number = n10 - 1;   
                int[] step = new int[number + 1];

                //representative of each step
                step[0] = 0;
                step[1] = 1;
                step[2] = 2;

                //iterate through all step options 
                for (int i = 3; i <= number; i++)
                {
                    step[i] = step[i - 3] + step[i - 2] + step[i - 1];
                }

                Console.WriteLine(step[number]);

                

                //Self Reflection:  though i spend a couple hours trying to resolve this problem, im still confused as to how to
                 //implement number sequences into C# code language, but with each more problem that I struggle with, i become each
                  //time more familiar with the process.



            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

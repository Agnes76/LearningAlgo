using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningAlgo
{
    public class staircase
    {
        static void Main(string[] args)
        {
            
        }

        public static void Print(int n)
        {
            
            for (int i = 1; i <= n; i++)
            {
                string str = "";
                for (int j = 0; j < i; j++)
                {
                    str += "#";
                }
                Console.WriteLine(str);
            }
           
        }
        // Explanation
        //1. when i = 1, it iterate through the first loop and declare an empty string
        // Then iterates the second loop once and concatenate "#", go through the second 
        // loop again, j = 1, and i is 1 which makes it break from the second loop

        //2.  when i = 2, it iterate through the first loop and declare an empty string
        // Then iterates the second loop once and concatenate "#", go through the second 
        // loop again, j = 1, and i is 2, it will concatenate "#" again, Then go through the same loop
        // j= 2 now and i = 2, so it will break (making ##)

        //3. when i = 3, it iterate through the first loop and declare an empty string
        // Then iterates the second loop once and concatenate "#", go through the second 
        // loop again, j = 1, and i is 2, it will concatenate "#" again, Then go through the same loop
        // j= 2 now and i = 3,it will concatenate "#" again, go through the loop again, j=3 and i =3,
        // so it will break (making ###)

        public static void PrintDetails(int n)
        {

            for (int i = n; i >= 1; i--)
            {
                string str = "";
                for (int j = i; j > 1; j--)
                {
                    str += " ";
                }
                for (int k = n; k >= i; k--)
                {
                    str += "#";
                }
                Console.WriteLine(str);
            }

        }

        //explanation
        //1. when it iterate through the first loop, let's assume n = 5, i would be equal to n which is 5
        // the 5 is greater than 1, it would declare the empty string, then enters the first inner loop,check
        // the condition, j = i which is 5, 5 is greater than 1, it would enter, declare the whitespace(" "), and
        // decrement j to 4, 4 is greater than 1, it would enter again, declare a second whitespace(" ") and decrement
        // j to 3, 3 is still greater than 1, it would enter again, declare a third whitespace(" ") and decrement j to 2,
        // 2 is still greater than 1, it would enter again , declare the fourth whitespace(" ") and decrement j to 1,
        // 1 is not greater than 1, it would break out of that loop and enter the Second inner loop, check the
        // condition K = n which is 5(had to use n cos it is a constant), K which is 5 is greater than or equal to i
        // which is 5, it would enter the loop and concatenate ("#") to the first 4 empty spaces, decrement k to 4, 4 is
        // not greater than or equal to i which is 5, so it breaks out of that loop. And start from the outer loop

        //2. it iterate through the first loop, i is now equal to 4, 4 is greater than 1, it would declare the empty string,
        //then enters the first inner loop,check the condition, j = i which is now 4, 4 is greater than 1, it would enter,
        //declare the whitespace(" "), decrement j to 3, 3 is still greater than 1, it would enter again, declare a second
        //whitespace(" ") and decrement j to 2, 2 is still greater than 1, it would enter again , declare the third whitespace(" ")
        //and decrement j to 1, 1 is not greater than 1, it would break out of that loop and enter the Second inner loop, check the
        // condition K = n which is 5(had to use n cos it is a constant), K which is 5 is greater than i
        // which is 4, it would enter the loop and concatenate ("#") to the first 4 empty spaces, decrement k to 4, 4 is
        // not greater than or equal to i which is 5, so it breaks out of that loop. And start from the outer loop

    }

}

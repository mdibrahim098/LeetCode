using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{


    // Approach 3
    //TC O(logn)
    //SC O(1)

    internal class Find_Smallest_Letter_Greater_Than_Target
    {
        public char NextGreatestLetter(char[] letters, char target)
        {
            int left = 0;
             int right = letters.Length-1; 
            while(left <= right)
            {

                int mid = left + (right - left)/2;
                if (letters[mid] <= target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return left < letters.Length ? letters[left] : letters[0];

        }
      /*  static void Main(string[] args)
        {
            Find_Smallest_Letter_Greater_Than_Target obj = new Find_Smallest_Letter_Greater_Than_Target();
            char[] letters = { 'c', 'f', 'j' };
            char target = 'd';
            Console.WriteLine(obj.NextGreatestLetter(letters, target));

        }*/
    }


    // Approach 2
    //TC O(nlogn)
    //SC O(1)
    /*
        internal class Find_Smallest_Letter_Greater_Than_Target
        {
            public char NextGreatestLetter(char[] letters, char target)
            {
                Array.Sort(letters);
                foreach (char letter in letters)
                {
                    if (letter > target) return letter;
                }
                return letters[0];

            }
            static void Main(string[] args)
            {
                Find_Smallest_Letter_Greater_Than_Target obj = new Find_Smallest_Letter_Greater_Than_Target();
                char[] letters = { 'c', 'f', 'j' };
                char target = 'd';
                Console.WriteLine(obj.NextGreatestLetter(letters, target));

            }
        }
    */

    // Approach 1 
    //TC O(n)
    //SC O(1)
    /*
        internal class Find_Smallest_Letter_Greater_Than_Target
        {
            public char NextGreatestLetter(char[] letters, char target)
            {
                for (int i = 0; i < letters.Length; i++)
                {
                    if (letters[i] == target && i < letters.Length - 1)
                    {
                        if (letters[i] != letters[i + 1])
                        {
                            return letters[i + 1];
                        }

                    }
                    else if (letters[i] == target && i == letters.Length - 1)
                    {
                        return letters[0];
                    }
                    else if (i < letters.Length - 1 && letters[i] < target && target < letters[i + 1])
                    {
                        return letters[i + 1];
                    }

                }
                return letters[0];
            }
            static void Main(string[] args)
            {
                Find_Smallest_Letter_Greater_Than_Target obj = new Find_Smallest_Letter_Greater_Than_Target();
                char[] letters = { 'c', 'f', 'j' };
                char target = 'd';
                Console.WriteLine(obj.NextGreatestLetter(letters, target));

            }
        }
      */

}

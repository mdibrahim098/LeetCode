using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{


    //Approach 2
    //TC O(n)
    //SC O(1)
    internal class Number_of_Substrings_Containing_All_Three_Characters
    {
        public int NumberOfSubstrings(string s)
        {
            int count = 0;
            int[] array = { -1, -1, -1 };
            for(int i=0; i<s.Length; i++)
            {
                array[s[i] - 'a'] = i;
                if (array[0] != -1 && array[1] != -1 && array[2] != -1)
                {
                    int a = array[0] < array[1] ? array[0] : array[1];
                    int b = array[2] < a ? array[2] : a;
                    count += (1+b);
                   
                }
            }

            return count;
        }
       /* static void Main(string[] args)
        {
            Number_of_Substrings_Containing_All_Three_Characters obj = new Number_of_Substrings_Containing_All_Three_Characters();


            string s = "abcabc";
            Console.WriteLine(obj.NumberOfSubstrings(s));
        }*/
    }


    /*
        //Approach 1
        //TC O(n^2)
        //SC O(1)
        internal class Number_of_Substrings_Containing_All_Three_Characters
        {
            public int NumberOfSubstrings(string s)
            {
                int count = 0;
                for(int i=0; i<s.Length; i++)
                {
                    int[] arr = new int[3];
                    for(int j=i; j<s.Length; j++)
                    {
                        arr[s[j] - 'a']++;
                        if (arr[0]>=1 && arr[1]>=1 && arr[2]>=1)
                        {
                            count++;
                        }  
                    }
                }
                return count;
            }
            static void Main(string[] args)
            {
                Number_of_Substrings_Containing_All_Three_Characters obj = new Number_of_Substrings_Containing_All_Three_Characters();


               string s = "aaacb";
                Console.WriteLine(obj.NumberOfSubstrings(s));
            }
        }*/
}

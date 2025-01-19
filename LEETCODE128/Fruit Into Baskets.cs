using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace LEETCODE128
{
    //Approach 3
    //TC O(n)
    //SC O(1)
    internal class Fruit_Into_Baskets
    {
        public int TotalFruit(int[] fruits)
        {

            Dictionary<int, int> dc = new Dictionary<int, int>();
            int left = 0;
            int right = 0;
            int maxLength = 0;
            while (right<fruits.Length)
            {

                if (dc.ContainsKey(fruits[right]))
                {
                    dc[fruits[right]]++;
                  
                }
                else
                {
                    dc[fruits[right]] = 1;
                    
                }

              if(dc.Count > 2)
                {
                    dc[fruits[left]]--;
                    if (dc[fruits[left]] == 0)
                    {
                        dc.Remove(fruits[left]);
                    }
                    left++;
                }

              if(dc.Count <= 2)
                {
                    maxLength = Math.Max(maxLength, right - left + 1);
                   

                }
                right++;

            }
            return maxLength;
        }
       /* static void Main(string[] args)
        {
            Fruit_Into_Baskets obj = new Fruit_Into_Baskets();
            int[] fruits = { 3, 3, 3, 1, 2, 1, 1, 2, 3, 3, 4 };
            Console.WriteLine(obj.TotalFruit(fruits));
        }*/
    }

    /* //Approach 2
     //TC O(n)
     //SC O(1)
     internal class Fruit_Into_Baskets
     {
         public int TotalFruit(int[] fruits)
         {

             Dictionary<int, int> dc = new Dictionary<int, int>();
             int left = 0;
             int right;
             int maxLength = 0;
             for(right=0; right<fruits.Length; right++)
             {

                 if (dc.ContainsKey(fruits[right]))
                 {
                     dc[fruits[right]]++;
                 }
                 else
                 {
                     dc[fruits[right]] = 1;
                 }

                 while (dc.Count > 2)
                 {
                     dc[fruits[left]]--;
                     if (dc[fruits[left]] == 0)
                     {
                         dc.Remove(fruits[left]);
                     }
                     left++;
                 }

                     maxLength = Math.Max(maxLength, right - left + 1);


             }
             return maxLength;
         }
         static void Main(string[] args)
         {
             Fruit_Into_Baskets obj = new Fruit_Into_Baskets();
             int[] fruits = { 3, 3, 3, 1, 2, 1, 1, 2, 3, 3, 4 };
             Console.WriteLine(obj.TotalFruit(fruits));
         }
     }*/

    //Approach 1
    //TC O(n^2)
    //SC O(1)
    /*internal class Fruit_Into_Baskets
    {
        public int TotalFruit(int[] fruits)
        {


            int maxLength = 0;
          
            for(int i=0; i<fruits.Length; i++)
            {
                HashSet<int> set = new HashSet<int>();
                int count = 0;
                for(int j=i; j<fruits.Length; j++)
                {
                    if(set.Count > 2)
                    {
                        break;
                    }
                    if (set.Contains(fruits[j]))
                    {
                        count++;
                       
                    }
                    else
                    {
                        set.Add(fruits[j]);
                        count++;
                    }
                    if(set.Count <= 2)
                    {
                        maxLength = Math.Max(maxLength, j - i + 1);
                    }
                   
                   }
            }
            return maxLength;
        }
        static void Main(string[] args)
        {
            Fruit_Into_Baskets obj = new Fruit_Into_Baskets();
            int[] fruits = { 3, 3, 3, 1, 2, 1, 1, 2, 3, 3, 4 };
            Console.WriteLine(obj.TotalFruit(fruits));
        }
    }*/
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{

    internal class Search_a_2D_Matrix
    {
        // Approach 2
        // TC O(log(m*n))
        // SC O(1)
        public bool SearchMatrix(int[][] matrix, int target)
        {
            int row = matrix.Length;
            int coloum = matrix[0].Length;
            int left = 0;
            int right = row * coloum - 1;
            while(left <= right)
            {
                int mid = left +(right - left)/2;
                if (matrix[mid/coloum][mid%coloum] == target)
                {
                    return true;
                }else if(matrix[mid / coloum][mid % coloum] > target)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            Console.WriteLine(coloum);
            return false;
        }

     /*   static void Main(string[] args)
        {
            Search_a_2D_Matrix obj = new Search_a_2D_Matrix();
            int target = 3;
            int[][] matrix = new int[][]
            {
               new int[] { 1, 3, 5, 7 },
               new int[] { 10, 11, 16, 20 },
               new int[] { 23, 30, 34, 60 }
            };
            Console.WriteLine(obj.SearchMatrix(matrix, target));

        }*/
    }


    // Approach 1 
    // TC O(m*n)
    // SC O(1)
    /*  internal class Search_a_2D_Matrix
      {

          public bool SearchMatrix(int[][] matrix, int target)
          {
              for(int i = 0;i< matrix.Length; i++)
              {
                   for(int j = 0;j< matrix[i].Length; j++)
                  {
                      if (matrix[i][j] == target)
                      {
                           return true;
                      }
                  }
              }
              return false;

          }

          static void Main(string[] args)
          {
              Search_a_2D_Matrix obj = new Search_a_2D_Matrix();
              int target = 3;
              int[][] matrix = new int[][]
              { 
                 new int[] { 1, 3, 5, 7 },
                 new int[] { 10, 11, 16, 20 }, 
                 new int[] { 23, 30, 34, 60 } 
              };
              Console.WriteLine(obj.SearchMatrix(matrix,target));

          }
      }*/

}

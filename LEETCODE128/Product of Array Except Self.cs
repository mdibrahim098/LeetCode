using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{

    // Approach 3
    // TC O(n)
    // SC O(1)


    internal class Product_of_Array_Except_Self
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int[] result = new int[nums.Length];
            result[0] = 1;
            int right = 1;
            for(int i=1; i<nums.Length; i++)
            {
                result[i] = nums[i - 1] * result[i-1];
            }
            for(int i=nums.Length-1; i>=0; i--)
            {
                result[i] = result[i] * right;
                right *= nums[i];
            }
            return result;
        }
        /*
        static void Main(string[] args)
        {
            Product_of_Array_Except_Self obj = new Product_of_Array_Except_Self();


            int[] nums = { 1, 2, 3, 4 };
            Console.WriteLine(string.Join(" ", obj.ProductExceptSelf(nums)));

        }
        */
    }




    /*
    // Approach 2
    // TC O(n)
    // SC O(n)

    internal class Product_of_Array_Except_Self
    {
        public int[] ProductExceptSelf(int[] nums)
        {
           int[] left = new int[nums.Length];
            int[] right = new int[nums.Length];
            left[0] = 1;
            right[nums.Length - 1] = 1;
            for(int i=1; i<nums.Length; i++)
            {
                left[i] = nums[i-1] * left[i-1];
            }
            for(int i=nums.Length-2; i>=0; i--)
            {
                right[i] = right[i+1]* nums[i+1];
            }
            int[] result = new int[left.Length];
            for(int i=0; i<nums.Length; i++)
            {
                result[i] = left[i]* right[i];
            }

            return result;

        }
        static void Main(string[] args)
        {
            Product_of_Array_Except_Self obj = new Product_of_Array_Except_Self();


            int[] nums = { 1, 2, 3, 4 };
            Console.WriteLine(string.Join(" ",obj.ProductExceptSelf(nums)) );
         
        }
    }




    /*
    // Approach 1
     // TC O(n)
     // SC O(1)
    internal class Product_of_Array_Except_Self
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int[] result = new int[nums.Length];
            int mul = 1;
            for(int i=0; i<nums.Length; i++)
            {
                mul *= nums[i];
            }
            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = mul / nums[i];
            }
            return result;
        }
        static void Main(string[] args)
        {
            Product_of_Array_Except_Self obj = new Product_of_Array_Except_Self();


           int [] nums = {1, 2, 3, 4};
            Console.WriteLine(string.Join(" ",obj.ProductExceptSelf(nums)));
        }
    }

    */
}

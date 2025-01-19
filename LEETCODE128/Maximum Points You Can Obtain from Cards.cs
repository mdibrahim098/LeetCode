using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{
    //TC O(n)
    //TC O(1)
    internal class Maximum_Points_You_Can_Obtain_from_Cards
    {
        public int MaxScore(int[] cardPoints, int k)
        {


            if (k == 1 && cardPoints.Length == 1)
            {
                return cardPoints[0];
            }

            int leftSum = 0;

            int maxPoints = 0;
            for (int i = 0; i < k; i++)
            {
                leftSum += cardPoints[i];
                maxPoints = Math.Max(maxPoints, leftSum);
            }
            int rightSum = 0;
            int right = cardPoints.Length - 1;
            for (int i = k - 1; i >= 0; i--)
            {
                leftSum -= cardPoints[i];
                rightSum += cardPoints[right];
                right--;
                maxPoints = Math.Max(maxPoints, leftSum + rightSum);

            }
            return maxPoints;
        }
       /* static void Main(string[] args)
        {
            Maximum_Points_You_Can_Obtain_from_Cards obj = new Maximum_Points_You_Can_Obtain_from_Cards();
            int[] cardPoints = {1, 2, 3, 4, 5, 6, 1}; int k = 3;
            Console.WriteLine(obj.MaxScore(cardPoints,k));
        }*/

    }
}

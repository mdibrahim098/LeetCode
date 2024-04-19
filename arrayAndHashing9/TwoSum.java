
package arrayAndHashing9;

import java.util.Arrays;
import java.util.HashMap;
import java.util.Map;

//Approach 2
//The time complexity of the provided code is O(n)
//The space complexity of the provided code is O(n).
class TwoSum {
    public int[] twoSum(int[] nums, int target) {
        Map<Integer,Integer> check = new HashMap<>();
        for(int i=0; i<nums.length;i++){
            int num = nums[i];
            int diff = target - num;
            if(check.containsKey(diff)){
              int[]array =  {check.get(diff),i};
                return array;
               // return  new int[] {check.get(diff),i};
                   }
             check.put(num, i);
            
        }
        return null;
        // return new int[] {};
    }
     public static void main(String[] args) {
        TwoSum obj = new TwoSum();
        int[] nums = {2,7,11,15};
        int target =9;
        int a=0 , b =0;
     
         System.out.println(Arrays.toString(obj.twoSum(nums, target)));
    }
}


//Another approach 1
//The time complexity of the provided code is O(n^2)
//The space complexity of the provided code is O(1).


/*
class  TwoSum1 {
    public int[] twoSum(int[] nums, int target) {
       
            for(int i=0;i<nums.length;i++)
            {
                for(int j=0;j<nums.length;j++)
                {
                    if(nums[i]+nums[j]==target)
                    {
                        return new int[]{i,j};
                    }
                }
            }
        
        return new int[]{};
     }
     public static void main(String[] args) {
        TwoSum1 obj = new TwoSum1();
        int[] nums = {2,7,11,15};
        int target =9;
        int a=0 , b =0;
     
         System.out.println(Arrays.toString(obj.twoSum(nums, target)));
    }
}

*/
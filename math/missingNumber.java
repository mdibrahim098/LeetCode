package math;


import java.util.Arrays;

import java.util.Arrays;

public class missingNumber {
    
}

class Solution {
    public int missingNumber(int[] nums) {
        Arrays.sort(nums);
        int n = nums.length;
        int sum = (n * (n+1)) /2;
        int x =Integer.MAX_VALUE ;
        for(int i=0; i<nums.length; i++){
           sum = sum - nums[i];
          x = Math.min(x,sum);
        }
           return x;
    }
    public static void main(String[] args) {
        Solution obj = new Solution();
        int [] nums = {3,0,1};
        System.out.println(obj.missingNumber(nums));
    }
}
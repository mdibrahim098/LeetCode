package slidingWindow6;

import java.util.Arrays;
import java.util.Deque;
import java.util.LinkedList;

//Time complexity: O(n)
//Space complexity: O(n)
public class SlidingWindowMaximum {

    public int[] maxSlidingWindow(int[] nums, int k) {
       int[] ans = new int [nums.length-k+1];
       int j=0;
       Deque<Integer> q = new LinkedList<>();
       for(int i=0; i<nums.length;i++){
           if(!q.isEmpty()&& q.peekFirst()<i-k+1){
               q.pollFirst();
           }
           while(!q.isEmpty()&& nums[i]>nums[q.peekLast()]){
               q.pollLast();
           }
           
           q.offer(i);
           if(i>=k-1){
               ans[j++] = nums[q.peekFirst()];
           }
       }
       return ans;
    }

    public static void main(String[] args) {
        SlidingWindowMaximum obj = new SlidingWindowMaximum();
        int[] nums = {1, 3, -1, -3, 5, 3, 6, 7};
        int k = 3;
        System.out.println(Arrays.toString(obj.maxSlidingWindow(nums, k)));
    }

}


//the corrected time complexity is O(n * k).
//Space complexity: O(n)
/*
public class SlidingWindowMaximum {

    public int[] maxSlidingWindow(int[] nums, int k) {
        int[] result = new int[nums.length - k + 1];
        for (int i = 0; i < nums.length-2; i++) {
              int max  = nums[i];
              for(int j=i; j<i+k;j++){
                  max = Math.max(max, nums[j]);
              }
              result[i]= max;
        }
                return result;
    }

    public static void main(String[] args) {
        SlidingWindowMaximum obj = new SlidingWindowMaximum();
        int[] nums = {1, 3, -1, -3, 5, 3, 6, 7};
        int k = 3;
        System.out.println(Arrays.toString(obj.maxSlidingWindow(nums, k)));
    }

}

*/
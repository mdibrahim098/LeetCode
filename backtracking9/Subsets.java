
package backtracking9;

import java.util.ArrayList;
import java.util.List;

//Time complexity O(n 2^n) where n is the length of the array
//space complexity O(n 2^n)
public class Subsets {
     public List<List<Integer>> subsets(int[] nums) {
        List<List<Integer>> result = new ArrayList<>();
        backtrack(result, new ArrayList<>(), nums, 0);
        return result;
    }
     private void backtrack(List<List<Integer>> result, List<Integer> temp , int[] nums, int start){
         result.add(new ArrayList<>(temp));
         for(int i=start; i< nums.length; i++){
             temp.add(nums[i]);
             backtrack(result, temp, nums, i+1);
             temp.remove(temp.size()-1);
         }
         
     }
     
     public static void main(String[] args) {
        Subsets obj = new Subsets();
         int [] nums = {1,2,3};
         System.out.println(obj.subsets(nums));
         
    }
}


package backtracking9;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

//Time Complexity: O(NlogN +2^N)
//Space Complexity: O(N*2^N)
//where N is the length of the array


public class SubsetsII {
     public List<List<Integer>> subsetsWithDup(int[] nums) {
        List<List<Integer>> ans = new ArrayList<>();
        List<Integer> ds = new ArrayList<>();
        Arrays.sort(nums);
        backtrack(nums, ans, ds, 0);
        return ans;
         
    }
     private void backtrack(int[] nums, List<List<Integer>> ans, List<Integer> ds , int start){
         if(ans.contains(ds)){
               return;
         }
           
        
         ans.add(new ArrayList<>(ds));
         for(int i=start; i<nums.length; i++){
             ds.add(nums[i]);
             backtrack(nums, ans,ds,i+1);
             ds.remove(ds.size()-1);
         }
     }
     
    public static void main(String[] args) {
        SubsetsII  obj = new SubsetsII();
        int[] nums = {1,2,2};
        System.out.println(obj.subsetsWithDup(nums));
    }
     
}

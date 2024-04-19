
package backtracking9;

import java.util.ArrayList;
import java.util.List;

//Time Complexity: O(N* N!)
//Space Complexity: O(N) + O(N)
//where n is the length of the nums array
public class Permutations {
    
    
      public List<List<Integer>> permute(int[] nums) {
        List<List<Integer>> ans = new ArrayList<>();
        List<Integer> ds = new ArrayList<>();
        boolean [] freq = new boolean[nums.length];
        recurPermute(freq, nums, ans, ds);
        return ans;
    }
      private void recurPermute(boolean[] freq, int [] nums, List<List<Integer>> ans , List<Integer> ds){
          if(ds.size() == nums.length){
//              ds = new ArrayList<>(ds);
              ans.add(new ArrayList<>(ds));
          }
          
          for(int i=0; i<nums.length; i++){
              if(!freq[i]){
                  freq[i]= true;
                  ds.add(nums[i]);
                  recurPermute(freq, nums, ans,ds);
                  ds.remove(ds.size()-1);
                  freq[i] = false;
              }
          }
      }
      
      public static void main(String[] args) {
        Permutations obj = new Permutations();
          int [] nums = {1,2,3};
          System.out.println(obj.permute(nums));
    }
}

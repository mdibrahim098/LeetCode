package backtracking9;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
//approach 2
//Time Complexity: O(NlogN +2^T). N is the number of candidates array
//Space Complexity: O(N*2^N)
public class CombinationSumII {

    public List<List<Integer>> combinationSum2(int[] candidates, int target) {
      List<List<Integer>> ans = new ArrayList<>();
      List<Integer> ds = new ArrayList<>();
      Arrays.sort(candidates);
      combinations(0, candidates, target, ans, ds);
      return ans;
    }
    private void combinations(int index , int[] candidates, int target, List<List<Integer>> ans, List<Integer> ds){
        if(target == 0){
            ans.add(new ArrayList<>(ds));
            return;
        }
        for(int i=index; i<candidates.length; i++){
            if(i>index && candidates[i]== candidates[i-1]){
                continue;
            }
            if(candidates[i]>target){
                break;
            }
            ds.add(candidates[i]);
            combinations(i+1,candidates, target-candidates[i], ans, ds);
            ds.remove(ds.size()-1);
        }
        
    }

    public static void main(String[] args) {
        CombinationSumII obj = new CombinationSumII();

        int[] candidates = {10, 1, 2, 7, 6, 1, 5};
        int target = 8;
        System.out.println(obj.combinationSum2(candidates, target));
    }
}

//approach 1 same as combinationsum
//Time Complexity: O(NlogN +2^T). N is the number of candidates 
//Space Complexity: O(N*2^N)
/*
public class CombinationSumII {
    public List<List<Integer>> combinationSum2(int[] candidates, int target) {
        List<List<Integer>> ans = new ArrayList<>();
        List<Integer> ds = new ArrayList<>();
        Arrays.sort(candidates);
        combinations(0,candidates, target, ans, ds );
        return ans;
    }
    private void combinations(int index, int[] candidates, int target,List<List<Integer>> ans, List<Integer> ds){
        if(index == candidates.length){
            if(target ==0){
                if(ans.contains(ds)){
                    return;
                }
                ans.add(new ArrayList(ds));
            }
            return;
        }
           if(candidates[index]<=target){
            ds.add(candidates[index]);
            combinations(index+1, candidates, target- candidates[index], ans ,ds);
            
            ds.remove(ds.size()-1);
           }
           combinations(index+1, candidates, target, ans, ds);

    }

    public static void main(String[] args) {
        CombinationSumII obj = new CombinationSumII();

        int[] candidates = {10,1,2,7,6,1,5};
        int target = 8;
        System.out.println(obj.combinationSum2(candidates, target));
    }
}

*/

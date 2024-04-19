package backtracking9;

import java.util.ArrayList;
import java.util.List;
//Time Complexity: O(N*2^T). N is the number of candidates and t is the target sum
//Space Complexity: O(N*T)
public class CombinationSum {

    public List<List<Integer>> combinationSum(int[] candidates, int target) {
        List<List<Integer>> result = new ArrayList<>();
        findCombinations(0, candidates, target, result, new ArrayList<>());
        return result;
    }

    private void findCombinations(int index, int[] candidates, int target, List<List<Integer>> result, List<Integer> list) {
        if (index == candidates.length) {
            if (target == 0) {
                result.add(new ArrayList<>(list));
            } 
             return;
        }

        if (candidates[index] <= target) {
            list.add(candidates[index]);
            findCombinations(index, candidates, target - candidates[index], result, list);
            list.remove(list.size() - 1);
        }
            findCombinations(index + 1, candidates, target, result, list);
       

    }

    public static void main(String[] args) {
        CombinationSum obj = new CombinationSum();

        int[] candidates = {2, 3, 6, 7};
        int target = 7;
        System.out.println(obj.combinationSum(candidates, target));
    }
}

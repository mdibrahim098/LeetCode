package twoPointers5;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.HashSet;
import java.util.List;
import java.util.Set;


// Time complexity O(n^2)
// Space complexity O(n)
public class Sum3 {

    public List<List<Integer>> threeSum(int[] nums) {
        List<List<Integer>> list = new ArrayList<>();
        Arrays.sort(nums);
        for (int i = 0; i < nums.length - 2; i++) {

            if (i > 0 && nums[i] == nums[i - 1]) {
                continue;
            }
            int low = i + 1;
            int high = nums.length - 1;
            int target = 0 - nums[i];
            while (high > low) {
                if (nums[low] + nums[high] == target) {
                    while (low < high && nums[low] == nums[low + 1]) {
                        low++;
                    }
                    while (low < high && nums[high] == nums[high - 1]) {
                        high--;
                    }
                    list.add(Arrays.asList(nums[i], nums[low], nums[high]));
                    low++;
                    high--;
                }
                
                else if ((nums[low] + nums[high]) < target)
                {
                    low++;
                }else{
                   high--;
                   }
            }
        }
        return list;
    }

    public static void main(String[] args) {
        Sum3 obj = new Sum3();
        int[] nums = {-1, 0, 1, 2, -1, -4};
        System.out.println(obj.threeSum(nums));
    }
}

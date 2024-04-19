
package binarySearch7;


// time complexity O(log(n))
// space complexity O(1)
public class FindMinimumInRotatedSortedArray {
    public int findMin(int[] nums) {
         int low = 0, high = nums.length - 1;
        int ans = Integer.MAX_VALUE;
      
        while (low <= high) {
            int mid = (low + high) / 2;

            //if left part is sorted:
            if (nums[low] <= nums[mid]) {
                // keep the minimum:
                ans = Math.min(ans, nums[low]);

                // Eliminate left half:
               
               low = mid+1;

            } else { //if right part is sorted:

                // keep the minimum:
                ans = Math.min(ans, nums [mid]);

                // Eliminate right half:
                high = mid - 1;
            }
        }
        return ans;
    }
    
    public static void main(String[] args) {
        FindMinimumInRotatedSortedArray obj = new FindMinimumInRotatedSortedArray();
        
         int [] nums = {3,4,5,1,2};
         System.out.println(obj.findMin(nums));
    }
}

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package binarySearch7;

//Time complexity O(log(n))
//Space complexity O(1)
public class SearchInRotatedSortedArray {

    public int search(int[] nums, int target) {

        int low = 0;
        int high = nums.length - 1;
        while (low <= high) {
            int mid = (low + high) / 2;

            // if mid points to the target
            if (nums[mid] == target) {
                return mid;
            }

            // if left part is sorted
            if (nums[low] <= nums[mid]) {
                if (nums[low] <= target && target <= nums[mid]) {
                    // element exists
                    high = mid - 1;
                } else {
                    // element does not exist
                    low = mid + 1;
                }
            } else { // if right part is sorted
                if (nums[mid] <= target && target <= nums[high]) {
                    // element exists
                    low = mid + 1;
                } else {
                    // element does not exist
                    high = mid - 1;
                }
            }
        }
        return -1;
    }

    public static void main(String[] args) {
        SearchInRotatedSortedArray obj = new SearchInRotatedSortedArray();
        int[] nums = {4, 5, 6, 7, 0, 1, 2};
        int target = 0;
        System.out.println(obj.search(nums, target));
    }
}

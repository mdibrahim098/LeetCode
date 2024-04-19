
package binarySearch7;

//Time complexity: O(log n)
//Space complexity: O(1)
public class BinarySearch {
      public int search(int[] nums, int target) {
        int left = 0;
        int right = nums.length-1;
        while(right>=left){
            int mid = (right+left)/2;
            if(nums[mid]==target){
                return mid;
            }else if (nums[mid]>target){
               right = mid -1;
            }else if(nums[mid]<target){
               left = mid+1;
            }
            
        }
        return -1;
    }
      public static void main(String[] args) {
        BinarySearch obj = new BinarySearch();
          
        int []   nums = {-1,0,3,5,9,12};
        int target = 9;
          System.out.println(obj.search(nums, target));
    }
}

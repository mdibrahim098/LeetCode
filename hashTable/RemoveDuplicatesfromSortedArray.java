
package hashTable;

import java.util.Arrays;
import java.util.HashSet;

//time complexity O(n);
//Space Complexity O(1);
public class RemoveDuplicatesfromSortedArray {
     public int removeDuplicates(int[] nums) {
     int i= 1;
     for(int j=1; j<nums.length; j++){
         if(nums[j]!= nums[j-1]){
             nums[i] =nums[j];
             i++;
         }
     }
     return i;
    }
     public static void main(String[] args) {
        RemoveDuplicatesfromSortedArray obj = new RemoveDuplicatesfromSortedArray();
         int [] nums = {0,0,1,1,1,2,2,3,3,4};
         System.out.println(obj.removeDuplicates(nums));
    }
}

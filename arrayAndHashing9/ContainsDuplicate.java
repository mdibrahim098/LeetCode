
package arrayAndHashing9;

import java.util.HashSet;

import java.util.Set;

//aproach 1
// Time complexity O(n)
// Space Complexity O(n)
class Solution {
    public boolean containsDuplicate(int[] nums) {
    Set<Integer> in = new HashSet<>();
    for(int num :nums){
        if(in.contains(num)){
            return true;
        }
         in.add(num);
    }
        
       return false;
    }
    public static void main(String[] args) {
        int[] nums = {1,2,3,4,1};
        Solution obj = new Solution();
        
         System.out.println(obj.containsDuplicate(nums)); 

    }
}



// aproach2
// Time complexity O(n^2)
// Space Complexity O(1)
class Solution1 {
    public boolean containsDuplicate(int[] nums) {
         for(int i=0;i<nums.length;i++){
             for(int j=i+1;j<nums.length;j++){
                 if(nums[i]==nums[j]){
                     return true;
                 }
             }
         }
         return false;
    }
    public static void main(String[] args) {
        int[] nums = {1,2,3,4,1};
        Solution1 obj = new Solution1();
        
         System.out.println(obj.containsDuplicate(nums)); 

    }
}
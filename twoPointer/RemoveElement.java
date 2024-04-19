
package twoPointer;
//TC O(n);
//SC O(1);
public class RemoveElement {
     public int removeElement(int[] nums, int val) {
        int index =0;
        for(int i=0; i< nums.length; i++){
            if(nums[i]==val){
               continue;
            }else{
                 nums[index]= nums[i];
                index++;
            }
        }
        return index; 
    }
    
    public static void main(String[] args) {
        RemoveElement obj = new RemoveElement();
       int [] nums = {0,1,2,2,3,0,4,2};
        int val = 2;
        System.out.println(obj.removeElement(nums, val));
    }
}

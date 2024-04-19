package arrayAndHashing9;

import java.util.Arrays;

//Output: [24,12,8,6]
//Approach 3
//The time complexity of the productExceptSelf method is O(n).
//The space complexity of the productExceptSelf method is O(1).
class ProductOfArrayExceptSelf {

    public int[] productExceptSelf(int[] nums) {
           int n = nums.length;
           int [] result = new int[n];
           result[0] = 1;
           for(int i=1; i<n;i++){
               result[i] = result[i-1] *nums[i-1];
           }
           int r = 1;
           for(int i=n-1; i>=0;i--){
               result[i] = result[i] * r;
               r *= nums[i];
           }
           return result;
    }

    public static void main(String[] args) {
        ProductOfArrayExceptSelf obj = new ProductOfArrayExceptSelf();
        int[] nums = {1, 2, 3, 4};
        System.out.println(Arrays.toString(obj.productExceptSelf(nums)));
    }
}


//Approach 2
//The time complexity of the productExceptSelf method is O(n).
//The space complexity of the productExceptSelf method is O(n).
/*
class ProductOfArrayExceptSelf {

    public int[] productExceptSelf(int[] nums) {
              int n = nums.length;     
        int [] prefix = new int[n];
        int [] suffix = new int[n];
        prefix[0] = 1;
        suffix[n-1] = 1;
        for(int i =1; i< n;i++){
            prefix[i] = prefix[i-1] * nums[i-1];
        }
        
        for(int i=n-2; i>=0;i--){
            suffix[i]=suffix[i+1]* nums[i+1];
        }
        int [] result = new int[n];
        for(int i=0; i<n;i++){
            result[i] = prefix[i]*suffix[i];
        }
        return result;
    }

    public static void main(String[] args) {
        ProductOfArrayExceptSelf obj = new ProductOfArrayExceptSelf();
        int[] nums = {1, 2, 3, 4};
        System.out.println(Arrays.toString(obj.productExceptSelf(nums)));
    }
}
*/

//Approach 1
// But problem is they mention in the question that doesn't us division operator
//The time complexity of the productExceptSelf method is O(n).
//The space complexity of the productExceptSelf method is O(n).
/*
 class ProductOfArrayExceptSelf {

    public int[] productExceptSelf(int[] nums) {
                    int mul  =1;
                    int [] result = new int [nums.length];
                for(int i=0; i<nums.length;i++){
                    mul = mul * nums[i];
                }
                for(int i =0;i<nums.length;i++){
                    result[i]= mul/nums[i];
    }
            return result;    
    }

    public static void main(String[] args) {
        ProductOfArrayExceptSelf obj = new ProductOfArrayExceptSelf();
        int[] nums = {1, 2, 3, 4};
        System.out.println(Arrays.toString(obj.productExceptSelf(nums)));
    }
}
*/
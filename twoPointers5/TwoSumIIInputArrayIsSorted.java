package twoPointers5;

import java.util.Arrays;
import java.util.HashMap;
import java.util.Map;

//Approach 3
//The time complexity of the provided code is O(n), where 
//n is the length of the array nums.
//The space complexity of the provided code is also O(1)
class TwoSumIIInputArrayIsSorted {
     public int[] twoSum(int[] numbers, int target) {
             int i=0; 
             int j= numbers.length-1;
             while (numbers[i]+numbers[j]!=target){
         if (numbers[i]+numbers[j]>target){
             j--;
         }else{
             i++;
         }
     }
               return new int[] {i,j};
    }
     public static void main(String[] args) {
        TwoSumIIInputArrayIsSorted obj = new TwoSumIIInputArrayIsSorted ();
                int [] numbers = {2,7,11,15};
                int targer = 9; 
                System.out.println(Arrays.toString(obj.twoSum(numbers, targer)));
    }
}




//Approach 2
//The time complexity of the provided code is O(n^2), where 
//n is the length of the array numbers.
//The space complexity of the provided code is also O(1), 

/*
class TwoSumIIInputArrayIsSorted {
     public int[] twoSum(int[] numbers, int target) {
       for (int i=0; i<numbers.length;i++){
           for(int j=0; j<numbers.length;j++){
               if(numbers[i]+numbers[j]== target){
                   return new int [] {i,j};
               }
           }
       }
       return null;
    }
     public static void main(String[] args) {
        TwoSumIIInputArrayIsSorted obj = new TwoSumIIInputArrayIsSorted ();
                int [] numbers = {2,7,11,15};
                int targer = 9; 
                System.out.println(Arrays.toString(obj.twoSum(numbers, targer)));
    }
}
*/



// Approach 1
//The time complexity of the provided code is O(n), where 
//n is the length of the array nums.
//The space complexity of the provided code is also O(n), where 
//n is the length of the array numbers.

/*
class TwoSumIIInputArrayIsSorted {
     public int[] twoSum(int[] numbers, int target) {
         Map<Integer,Integer> map = new HashMap<>();
         for(int i=0; i<numbers.length;i++){
             int number = target -numbers[i];
             if(map.containsKey(number)){
                 int [] array = {map.get(number),i};
                 return array;
             }
             map.put(numbers[i],i);
         }
         return null;
    }
     public static void main(String[] args) {
        TwoSumIIInputArrayIsSorted obj = new TwoSumIIInputArrayIsSorted ();
                int [] numbers = {2,7,11,15};
                int targer = 9; 
                System.out.println(Arrays.toString(obj.twoSum(numbers, targer)));
    }
}


*/
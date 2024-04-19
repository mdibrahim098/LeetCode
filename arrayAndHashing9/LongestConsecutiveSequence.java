package arrayAndHashing9;

import java.util.HashMap;
import java.util.HashSet;
import java.util.Map;
import java.util.Set;

//approach 2
//The time complexity of the provided code is O(n^2).
//The space complexity of the provided code is O(n).
class LongestConsecutiveSequence {
     public int longestConsecutive(int[] nums) {
        int longestLength = 0;
        Set<Integer> set = new HashSet<>();
        for(int num :nums){
            set.add(num);
            
        }
        for(int num: nums){
            int currentLength= 1;
            // check forward direction
            int forwardNum= num+1;
            while(set.remove(forwardNum)){
                currentLength++;
                forwardNum++;
            }
            //check backward direction
            int backwardNum = num-1;
            while(set.remove(backwardNum)){
                currentLength++;
                backwardNum--;
            }
            if(currentLength>longestLength){
                longestLength = currentLength;
            }
        }
        return longestLength;
    }
    
    public static void main(String[] args) {
          LongestConsecutiveSequence obj = new LongestConsecutiveSequence();
        
        
        int [] nums = {100,4,200,1,3,2};
//        int [] nums = {0,3,7,2,5,8,4,6,0,1};
              int s = obj.longestConsecutive(nums);
              System.out.println(s);
    }
}




//approach 1
//The time complexity of the provided code is O(n^2).
//The space complexity of the provided code is O(n).
/* class LongestConsecutiveSequence {

    public int longestConsecutive(int[] nums) {
        int longestLength =0;
        Map<Integer,Boolean> map = new HashMap<>();
        for(int num :nums){
            map.put(num, Boolean.FALSE);
        }
        
            
        for(int num:nums){
        int currentLength=1;
            //Check Forward direction
            int forwardNum = num+1;
            while(map.containsKey(forwardNum)&& map.get(forwardNum)==false){
                currentLength++;
                map.put(forwardNum, Boolean.TRUE);
                forwardNum++;
            }
            //Check backward direction
            int backwardNum = num-1;
            while(map.containsKey(backwardNum)&&map.get(backwardNum)==false){
                currentLength++;
                map.put(backwardNum, Boolean.TRUE);
                backwardNum--;
            }
            longestLength = Math.max(longestLength, currentLength);
        }
       return  longestLength;
    }

    public static void main(String[] args) {
        LongestConsecutiveSequence obj = new LongestConsecutiveSequence();

        int[] nums = {100, 0, 200, -1, 1, 2};
//        int [] nums = {0,3,7,2,5,8,4,6,0,1};
        int s = obj.longestConsecutive(nums);
        System.out.println(s);
    }
}

*/
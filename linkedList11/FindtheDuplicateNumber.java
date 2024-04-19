package linkedList11;



//aproach 3
//Time complexity O(n)
//Space complexity O(1)
public class FindtheDuplicateNumber {

    public int findDuplicate(int[] nums) {
   int slow = 0;
   int fast =0;
   do{
       slow = nums[slow];
       fast = nums[nums[fast]];
    }while(fast!=slow);
   
   slow =0;
   while(fast!=slow){
       slow= nums[slow];
       fast = nums[fast];
   }
   return slow;
    }

    public static void main(String[] args) {
        FindtheDuplicateNumber obj = new FindtheDuplicateNumber();

        int[] nums = {1, 3, 4, 2, 2};
        System.out.println((obj.findDuplicate(nums)));

    }
}


//approach 2
//the time complexity is O(N ) 
//the space complexity is O(N), 
//where N is the number of elements in the array nums
/*
public class FindtheDuplicateNumber {

    public int findDuplicate(int[] nums) {
     Set<Integer> set = new HashSet<>();
     int num=0;
     int n= nums.length;
      while(n>0){
          if(set.contains(nums[num])){
              return nums[num];
          }
          set.add(nums[num]);
          num++;
          n--;
      }
      return -1;
    }

    public static void main(String[] args) {
        FindtheDuplicateNumber obj = new FindtheDuplicateNumber();

        int[] nums = {1, 3, 4, 2, 2};
        System.out.println((obj.findDuplicate(nums)));

    }
}
*/

//Approach 1
 //the time complexity is O(N log N) 
//the space complexity is O(1), 
//where N is the number of elements in the array nums
/*
public class FindtheDuplicateNumber {

    public int findDuplicate(int[] nums) {
        Arrays.sort(nums);

        for (int i = 1; i < nums.length; i++) {
            if (nums[i - 1] == nums[i]) {
                return nums[i];
            }
        }
        return -1;
    }

    public static void main(String[] args) {
        FindtheDuplicateNumber obj = new FindtheDuplicateNumber();

        int[] nums = {1, 3, 4, 2, 2};
        System.out.println((obj.findDuplicate(nums)));

    }
}

*/
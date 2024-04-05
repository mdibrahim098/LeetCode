
package hashTable;

import java.util.HashSet;

//time complexity o(logn);
//space Complexity O(n)
//where n is the input value
public class HappyNumber {
     public boolean isHappy(int n) {
        HashSet<Integer> hashset = new HashSet<>();
         while(true){
             int sum =0;
             while(n!=0){
                 sum += Math.pow(n%10,2);
                 n = n/10;
             }
             if(sum==1){
                 return true;
             }
             n = sum;
             if(hashset.contains(sum)){
                 return false;
             }
             hashset.add(sum);
         }
    }
     public static void main(String[] args) {
        HappyNumber obj = new HappyNumber();
        int n = 1236;
         System.out.println(obj.isHappy(n));
    }
                            
}

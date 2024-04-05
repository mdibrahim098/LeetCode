
package string;

//Time complexity O(n^2)
//Space complexity O(n)
public class MaximumLengthSubstringWithTwoOccurrences {
     public int maximumLengthSubstring(String s) {
        
         int max =0;
          
         for(int i=0;i<s.length();i++){
             int[] array = new int[26]; 
             for(int j=i;j<s.length();j++){
                 
                  array[s.charAt(j)-'a'] =  array[s.charAt(j)-'a'] +1;
              int a =  array[s.charAt(j)-'a'];
                 if( a==3){
                     break;
                 }
                 max = Math.max(max,j-i+1);
             }
         }
         
             return max;
         }
     public static void main(String[] args) {
         
         MaximumLengthSubstringWithTwoOccurrences obj = new MaximumLengthSubstringWithTwoOccurrences();
       String  s = "bcbbbcba";
         System.out.println(obj.maximumLengthSubstring(s));
    }
}


package slidingWindow6;

import java.util.Arrays;


//Time complexity: O(n + m)
//Space complexity: O(1)

public class PermutationInString {
      public boolean checkInclusion(String s1, String s2) {
         int n = s1.length();
        int[] frequencyS1 = new int[26];
        for (int i = 0; i < n; i++) {
            frequencyS1[s1.charAt(i) - 'a']++;
        }

        int m = s2.length();
        int[] frequencyS2 = new int[26];

        for (int i = 0; i < m; i++) {
            frequencyS2[s2.charAt(i) - 'a']++;
            // window size check 
            if (i >= n) {
                 frequencyS2[s2.charAt(i-n)-'a']--;
            }
            if(Arrays.equals(frequencyS1, frequencyS2)){
                return true;
            }
   
        }
         return false;
      }
    public static void main(String[] args) {
        PermutationInString obj = new PermutationInString();
        String s1 = "ab";
        String s2 = "eidbaooo";
        System.out.println(obj.checkInclusion(s1, s2));
    }
}

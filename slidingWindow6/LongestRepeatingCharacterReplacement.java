

package slidingWindow6;


//the time complexity of the provided code is O(n) where n is the length of the string s
//the space complexity of the provided code is O(1), constant space complexity.


public class LongestRepeatingCharacterReplacement {
      public int characterReplacement(String s, int k) {
           int[] array = new int[26];
        int maxLength = 0;
        int maxfrequent = 0;
        int left = 0;
        for (int right = 0; right < s.length(); right++) {
            // arr[s.charAt(right) - 'A'] = arr[s.charAt(right) - 'A'] +1;
            // arr [A-A] = arr[A-A]+1;
            // arr[0] = arr[0] +1;
            // arr[0] = 0+1;
            // arr[0] = 1;
            array[s.charAt(right) - 'A']++;

            maxfrequent = Math.max(maxfrequent, array[s.charAt(right) - 'A']);
            // window size = righr - left +1
            // check window size -maxfrequent>k 
            if (right - left + 1 - maxfrequent > k) {

                array[s.charAt(left) - 'A']--;
                left++;
            }
            maxLength = Math.max(maxLength, right - left + 1); // window size = valid  max String size = right -left +1

        }
        return maxLength;
          
          
    }
    public static void main(String[] args) {
        LongestRepeatingCharacterReplacement obj = new LongestRepeatingCharacterReplacement();
       String  s = "AABABBA";
         int k = 1;
         System.out.println(obj.characterReplacement(s, k));
    }
}

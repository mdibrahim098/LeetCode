
package slidingWindow6;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

//Approach2
// Time Complexity O(n)
// Space Complexity O(n)
class LongestSubstringWithoutRepeatingCharacters {
    
      public int lengthOfLongestSubstring(String s) {
       List<Character> substringL = new ArrayList<>();
            int largestlength = 0;
            for(int right = 0; right < s.length(); right++) {
                if(substringL.contains(s.charAt(right))) { 
                    // get the index of the char
                    int index = substringL.indexOf(s.charAt(right));
                    substringL.remove(index);
                    if(index > 0)
                        substringL.subList(0, index).clear();
                }
                substringL.add(s.charAt(right));
                largestlength = Math.max(largestlength, substringL.size());
            }
            return largestlength;
    }
    
    
           public static void main(String[] args) {
        LongestSubstringWithoutRepeatingCharacters obj = new LongestSubstringWithoutRepeatingCharacters();
        String s = "abcabcbb";
               System.out.println(obj.lengthOfLongestSubstring(s));
    }
         
}


//Approach 1
// Time Complexity O(n)
// Space Complexity O(n)
/* 
class LongestSubstringWithoutRepeatingCharacters {
    
      public int lengthOfLongestSubstring(String s) {
        Map<Character,Integer> map = new HashMap<>();
        int start = 0;
        int length = 0;
        for(int end =0;end<s.length();end++){
            char c = s.charAt(end);
            if(map.containsKey(c)){
                 if(start<= map.get(c)){
                start = map.get(c)+1;
            }
            }
            length = Math.max(length, end -start+1);
            map.put(c, end);
           
        }
        return length;
                
        
    }
    
    
           public static void main(String[] args) {
        LongestSubstringWithoutRepeatingCharacters obj = new LongestSubstringWithoutRepeatingCharacters();
        String s = "abcabcbb";
               System.out.println(obj.lengthOfLongestSubstring(s));
    }
         
}

*/
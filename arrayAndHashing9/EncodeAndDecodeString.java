package arrayAndHashing9;

import java.util.ArrayList;
import java.util.List;

//Time Complexity: O(L)+O(N)
//Space Complexity: O(L)

public class EncodeAndDecodeString {
    //Encode a list of string to a single String

    public String encode(List<String> strs){
       StringBuilder sb = new StringBuilder();
       for (String str : strs){
           sb.append(str.length()).append('/').append(str);
       }
     
  return sb.toString();
    }
    
    // Decode a single string to a list of string
    
    public List<String> decode(String s){
      List<String> result = new ArrayList<>();
      int i =0;
      while(i<s.length()){
          int slash = s.indexOf('/', i);
          int size = Integer.valueOf(s.substring(i, slash));
          i = size +slash +1;
        
          result.add(s.substring(slash+1, i));
      }
      
       return result;
    }
    
    public static void main(String[] args) {
        EncodeAndDecodeString obj = new EncodeAndDecodeString();
        List<String> strs = new ArrayList<>();
        strs.add("Hello");
        strs.add("World");
       
        String s = obj.encode(strs);
        System.out.println(obj.decode(s));
    }
}

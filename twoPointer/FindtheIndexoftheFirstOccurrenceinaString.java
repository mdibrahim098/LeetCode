
package twoPointer;

//TC O(n)
//SC O(1)
public class FindtheIndexoftheFirstOccurrenceinaString {
     public int strStr(String haystack, String needle) {
      
        for(int i =0; i<haystack.length()-needle.length()+1; i++){
          if( haystack.charAt(i)== needle.charAt(0)){
              if(  haystack.substring(i, needle.length()+i).equals(needle)){
                  return i;
              }
             
          }
        }
        return -1;
    }
    
    
    public static void main(String[] args) {
        FindtheIndexoftheFirstOccurrenceinaString obj = new FindtheIndexoftheFirstOccurrenceinaString();
        
       String  haystack = "sadbutsad";
       String needle = "sad";
        System.out.println(obj.strStr(haystack, needle));
    }
}

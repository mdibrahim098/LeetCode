package backtracking9;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

//Time Complexity: O(n*4^n)
//where n is the lengtyh of the string
//Space Complexity: O(n*4^n)
public class LetterCombinationsOfAPhoneNumber {
   Map<Character,String> digitToChar;
     public List<String> letterCombinations(String digits) {
        digitToChar = new HashMap<>();
         digitToChar.put('2',"abc" );
         digitToChar.put('3',"def");
         digitToChar.put('4',"ghi");
         digitToChar.put('5',"jkl" );
         digitToChar.put('6',"mno" );
         digitToChar.put('7',"pqrs");
         digitToChar.put('8',"tuv");
         digitToChar.put('9',"wxyz" );
        
        if(digits.length()==0){
            return new ArrayList<>();
        }
        List<String> ans = new ArrayList<>();
        String cur = "";
        backtrack(digits, cur,ans,0);
        return ans;
    }
     private void backtrack(String digits, String cur, List<String> ans , int index){
         if(cur.length()== digits.length()){
             ans.add(cur);
             return;
         }
         else if(index>= digits.length()){
             return;
         }
         else{
             String digit = digitToChar.get(digits.charAt(index));
             
         for(char c:digit.toCharArray()){
            
             backtrack(digits, cur+c, ans, index+1); 
         }
         }
     }
     public static void main(String[] args) {
        LetterCombinationsOfAPhoneNumber obj = new LetterCombinationsOfAPhoneNumber();
        String digits = "23";
         System.out.println(obj.letterCombinations(digits));
    }
}

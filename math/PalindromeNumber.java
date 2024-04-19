
package math;

//Time complexity  O(log10(x) + n); where n is the lenth of the number
//space complexity  O(log10(x))
public class PalindromeNumber {
     public boolean isPalindrome(int x) {
        if(x<0){
             return false;
        }
        else if(x ==0){
            return true;
        }else {
            String s = Integer.toString(x);
            char[] c = s.toCharArray();
            String s1 = "";
            for(int i =0; i< s.length(); i++){
                s1 = c[i] +s1;
            }
            if(s1.equals(s)){
                return true;
            }else{
                return false;
            }
        }
    

    }
     public static void main(String[] args) {
        PalindromeNumber obj = new PalindromeNumber();
        int x = 10;
         System.out.println(obj.isPalindrome(x));
    }
}

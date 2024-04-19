
package twoPointers5;

//Aproach 2
//The time complexity of the provided code is O(n),
//n is the length of the input string.
//The space complexity of the provided code is also O(1), 

class ValidPalindrome {
     public boolean isPalindrome(String s) {
       s = s.replaceAll("[^A-za-z0-9]", "").toLowerCase();
       int i =0 ; int j = s.length()-1;
       while(i<j){
           if(s.charAt(i)!= s.charAt(j)){
               return false;
           }
           i++;
           j--;
       }
       return true;
    }
     public static void main(String[] args) {
         ValidPalindrome obj = new ValidPalindrome();
       String s = "A man, a plan, a canal: Panama" ;

         System.out.println(obj.isPalindrome(s));
    }
}

//Aproach 1
//The time complexity of the provided code is O(n),
//n is the length of the input string.
//The space complexity of the provided code is also O(n), 
//n is the length of the input string.
 /*
 class ValidPalindrome {
     public boolean isPalindrome(String s) {
        String str = s.replaceAll("[^A-Za-z0-9]", "").toLowerCase();
        String st ="";
       
        for(int i=0; i<str.length();i++){
            st = str.charAt(i) + st;
        }
        if(st.contains(str)){
             return true;            
        }else{
           return false;
        }
    }
     public static void main(String[] args) {
         ValidPalindrome obj = new ValidPalindrome();
       String s = "A man, a plan, a canal: Panama" ;

         System.out.println(obj.isPalindrome(s));
    }
}

*/
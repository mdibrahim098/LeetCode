package arrayAndHashing9;

import java.util.Arrays;


//Approach 3
//Time complexity: O(n log n)
//Space complexity: O(n)
class validAnagram {
   
    public boolean isAnagram(String s, String t) {
       String[] c1 = s.split("");
      String[] c2 = t.split("");
      Arrays.sort(c1);
      Arrays.sort(c2);
      return Arrays.equals(c1, c2);
    }
    public static void main(String[] args) {
        validAnagram obj = new validAnagram();
        String s = "anagram";
        String t = "nagaram";
        System.out.println(obj.isAnagram(s, t));
    }
}











// aproach 2
//Time complexity: O(n log n)
//Space complexity: O(n)
/*
class validAnagram {
   
    public boolean isAnagram(String s, String t) {
       if(s.length()!= t.length()){
           return false;
       }
       String [] array1 = s.split("");
       Arrays.sort(array1);
       String [] array2 = t.split("");
       Arrays.sort(array2);
       for(int i=0; i<array1.length;i++){
           if(!array1[i].equals(array2[i])){
               return false;
           }
       }
       return true;
       
    }
    public static void main(String[] args) {
        validAnagram obj = new validAnagram();
        String s = "anagram";
        String t = "nagaram";
        System.out.println(obj.isAnagram(s, t));
    }
}

*/




//Approach 1
/*
//Time complexity: O(n log n)
//Space complexity: O(n)
class validAnagram {

    public boolean isAnagram(String s, String t) {
        if (s.length() != t.length()) {
            return false;

        }

        char[] c1 = s.toLowerCase().toCharArray();
        char[] c2 = t.toLowerCase().toCharArray();
        Arrays.sort(c1);
        Arrays.sort(c2);
        for (int i = 0; i < c1.length; i++) {
            if (c1[i] != c2[i]) {
                return false;

            }
        }
        return true;

    }

    public static void main(String[] args) {
        validAnagram obj = new validAnagram();
        String s = "anagram";
        String t = "nagaram";
        System.out.println(obj.isAnagram(s, t));
    }
}
*/
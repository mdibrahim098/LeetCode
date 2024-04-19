package stack7;

import java.util.Stack;

//Approach 2
//Time complexity: O(n)
//Space complexity: O(n)
public class ValidParentheses {

    public boolean isValid(String s) {
        Stack<Character> stack = new Stack<>();
        for (char c : s.toCharArray()) {
            if (c == '(') {
                stack.push(')');
            } else if (c == '{') {
                stack.push('}');
            } else if (c == '[') {
                stack.push(']');
            } else if (stack.isEmpty() || stack.pop() != c) {
                return false;
            }

        }
        return stack.isEmpty();

    }

    public static void main(String[] args) {
        ValidParentheses obj = new ValidParentheses();

        String s = "()[]{}";
        System.out.println(obj.isValid(s));
    }
}

// Approach 1
//Time complexity: O(n^2)
//Space complexity: O(n)
/*

public class ValidParentheses {
    
    public boolean isValid(String s) {
         while(true){
             if(s.contains("()")){
                 s= s.replace("()", "");
             }
                 else if(s.contains("{}")){
                    s= s.replace("{}", "");
                     
                 }
                 else if (s.contains("[]")){
                     s= s.replace("[]", "");
                 }
                 else{
                     return s.isEmpty();
                 }
             }
        }
    
    
    public static void main(String[] args) {
        ValidParentheses obj = new ValidParentheses();
        
        String s = "()[]{}";
        System.out.println(obj.isValid(s));
    }
}


 */

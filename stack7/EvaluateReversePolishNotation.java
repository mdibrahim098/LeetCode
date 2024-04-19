package stack7;

import java.util.Stack;

//Time complexity: O(n)
//Space complexity: O(n)
public class EvaluateReversePolishNotation {

    public int evalRPN(String[] tokens) {
        int a, b;
        Stack<Integer> stack = new Stack<Integer>();
        for (String token : tokens) {
            if (token.equals("+")) {
                stack.push(stack.pop() + stack.pop());
            } else if (token.equals("-")) {
                a = stack.pop();
                b = stack.pop();
                stack.push(b - a);
            } else if (token.equals("*")) {
                stack.push(stack.pop() * stack.pop());
            } else if (token.equals("/")) {
                a = stack.pop();
                b = stack.pop();
                stack.push(b / a);
            } else {
                stack.push(Integer.parseInt(token));
            }
        }
        return stack.peek();
    }

    public static void main(String[] args) {
        EvaluateReversePolishNotation obj = new EvaluateReversePolishNotation();
        String[] tokens = {"2", "1", "+", "3", "*"};

        System.out.println(obj.evalRPN(tokens));
    }

}

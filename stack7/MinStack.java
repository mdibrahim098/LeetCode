
package stack7;

import java.util.Stack;
//Time complexity: O(1) for all operations (push, pop, top, getMin).
//Space complexity: O(n), where n is the number of elements in the stack.
public class MinStack {
        Stack<Integer> stack = new Stack<>();
        Stack<Integer> minStack = new Stack<>();
    public MinStack() {

    }

    public void push(int val) {
         stack.push(val);
         if(minStack.isEmpty()){
             minStack.push(val);
             return;
         }
          
         if( minStack.peek()>val){
             minStack.push(val);
         }else{
             minStack.push( minStack.peek());
         }
    }

    public void pop() {
         stack.pop();
         minStack.pop();
    }

    public int top() {
  return stack.peek();
    }

    public int getMin() {
          return minStack.peek();
    }

    public static void main(String[] args) {
        MinStack obj = new MinStack();
        obj.push(-2);
        obj.push(0);
        obj.push(-3);
        System.out.println(obj.getMin());
        obj.pop();
        System.out.println(obj.top());
        System.out.println(obj.getMin());

    }
}

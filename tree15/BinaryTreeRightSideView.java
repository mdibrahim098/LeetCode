//
package tree15;

import java.util.LinkedList;
import java.util.List;

//Time complexity O(n);
//Space complexity O(n)
//where n is the total number of nodes
public class BinaryTreeRightSideView {
    Node root;
    public static class Node{
        int val ;
        Node left;
        Node right;

        public Node() {
        }

        public Node(int val) {
            this.val = val;
        }
        
    }

   
    
    public List<Integer> rightSideView(Node root) {
        List<Integer> result = new LinkedList<>();
        rightView(root, result, 0);
        return result;
    }
    public void rightView(Node root,List<Integer> result , int depth){
        if(root== null){
            return;
        }
        if(depth == result.size()){
            result.add(root.val);
        }
        rightView(root.right, result, depth+1);
        rightView(root.left , result, depth +1);
    }
    public static void main(String[] args) {
        BinaryTreeRightSideView obj = new BinaryTreeRightSideView();
        obj.root = new Node(1);
        obj.root.right = new Node(3);
        obj.root.right.right = new Node(4);
        obj.root.left = new Node(2);
        obj.root.left.right = new Node(5);
        System.out.println(obj.rightSideView(obj.root));
    }
}


package tree15;

import java.util.Arrays;
import java.util.HashMap;
import java.util.Map;
//Time complexity O(n)
//Space complexity O(n)
public class ConstructBinaryTreeFromPreorderAndInorderTraversal {
      
    public static class Node{
      Node root;
        int val;
        Node left;
        Node right;

        public Node() {
        }

        public Node(int val) {
            this.val = val;
        }
        
    }
    public Node buildTree(int[] preorder, int[] inorder) {
        Map<Integer, Integer> iMap = new HashMap<>();
        for(int i = 0; i<inorder.length ; i++){
            iMap.put(inorder[i], i);
        }
        Node root = build(preorder, 0, preorder.length -1, inorder, 0 ,inorder.length -1, iMap);
        return root;
    }
    private Node build(int[] preorder, int preStart, int preEnd,
            int [] inorder, int inStart, int inEnd, Map<Integer, Integer> iMap){
        
        if(preStart >preEnd || inStart >inEnd){
            return null;
        }
        Node root = new Node (preorder[preStart]);
        int inRoot = iMap.get(root.val);
        int numleft = inRoot - inStart;
        root.left = build(preorder, preStart+1, preStart + numleft, inorder, inStart , inRoot-1, iMap);
        root.right= build(preorder, preStart+numleft+1, preEnd , inorder, inRoot+1, inEnd, iMap);
        return root;
    } 
    
    public static void inorderTraversal(Node root){
        if(root== null){
            return;
        }
        inorderTraversal(root.left);
        System.out.print(root.val+" ");
        inorderTraversal(root.right);
    }
    public static void main(String[] args) {
        ConstructBinaryTreeFromPreorderAndInorderTraversal obj = new ConstructBinaryTreeFromPreorderAndInorderTraversal();
        
       int []  preorder = {3,9,20,15,7};
        int [] inorder = {9,3,15,20,7};
         Node root = obj.buildTree(preorder, inorder);
        inorderTraversal(root);
        System.out.println(" ");
    }
            
}

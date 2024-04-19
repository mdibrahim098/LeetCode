
package tree15;

// Time complexity O(n);
//space complexity O(n)
//where n is the total number of the node.
public class ValidateBinarySearchTree {
    
    
    Node root;
    public static class Node{
        int val;
        Node left;
        Node right;

        public Node() {
        }

        public Node(int val) {
            this.val = val;
        }
        
    }
       public boolean isValidBST(Node root) {
        return isValid(root, Long.MIN_VALUE,Long.MAX_VALUE);
    }
       private boolean isValid( Node root, long minVal , long maxVal){
           if(root == null){
               return true;
           }
           if(root.val>=maxVal || root.val <= minVal){
               return false;
           }
           boolean left = isValid(root.left, minVal,root.val);
           boolean right = isValid(root.right, root.val, maxVal);
           return left && right;
       }
       public static void main(String[] args) {
        ValidateBinarySearchTree obj = new ValidateBinarySearchTree();
        obj.root = new Node(5);
        obj.root.left= new Node(1);
        obj.root.right= new Node(6);
        obj.root.right.left= new Node(4);
        obj.root.right.right= new Node(8);
           System.out.println(obj.isValidBST(obj.root));
    }
}

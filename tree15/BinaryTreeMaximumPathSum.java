
package tree15;

//time complexity of O(n) where n is the total number of the node
//space complexity of O(h). where h is the height of the binary tree
public class BinaryTreeMaximumPathSum {
    Node root ;
    public static  class Node{
        int val;
        Node left;
        Node right;

        public Node() {
        }

        public Node(int val) {
            this.val = val;
        }
        
    }
     public int maxPathSum(Node root) {
        int[] max ={ Integer.MIN_VALUE};
        maxPath(root,max);
         return max[0];
    }
     private int maxPath(Node root, int[] max){
         if(root == null){
             return 0;
         }
         int left = Math.max(0, maxPath(root.left,max));
         int right = Math.max(0, maxPath(root.right, max));
         max[0] = Math.max(max[0], root.val +left +right);
         return root.val + Math.max(left,right);
     }
     
     public static void main(String[] args) {
        BinaryTreeMaximumPathSum obj = new BinaryTreeMaximumPathSum();
        obj.root = new Node(-10);
        obj.root.left = new Node(9);
        obj.root.right = new Node(20);
        obj.root.right.left = new Node(15);
        obj.root.right.right = new Node(7);
         System.out.println(obj.maxPathSum(obj.root));
    }
}

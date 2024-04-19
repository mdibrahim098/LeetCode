
package tree15;

//Time compexity O(n);
//Space complexity O(n);
public class BalancedBinaryTree {
    Node root;
     public static class Node {
         int val;
         Node left;
         Node right;

        public Node() {
        }

        public Node(int val) {
            this.val = val;
            this.left = null;
            this.right = null;
        }
         
     }
     public boolean isBalanced(Node root) {
        return dfsHeight(root) !=-1;
    }
     public int dfsHeight(Node root){
         if(root ==null){
             return 0;
         }
         int lh = dfsHeight(root.left);
         if(lh==-1){
             return -1;
         }
         int rh = dfsHeight(root.right);
         if(rh ==-1){
             return -1;
         }
         
         if(Math.abs(lh-rh)>1){
             return -1;
         }
         return Math.max(lh,rh) +1;
         
     }
     public static void main(String[] args) {
        BalancedBinaryTree obj = new BalancedBinaryTree();
        obj.root = new Node(3);
        obj.root.left = new Node(9);
        obj.root.right = new Node(20);
        obj.root.right.left = new Node(15);
        obj.root.right.right = new Node(7);
         System.out.println(obj.isBalanced(obj.root));
    }
}

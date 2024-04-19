
package tree15;

import java.util.Arrays;
import java.util.LinkedList;
import java.util.Queue;

//Approach iterative way
// Time complexity O(n), where n is the total number of node
// Space complexity O(n) , where n is the total number of node which store in a queue.
  class TreeNode{
        int val;
        TreeNode left;
        TreeNode right;

        public TreeNode() {
        }

        public TreeNode(int val) {
            this.val = val;
            
        }

        public TreeNode(int val, TreeNode left, TreeNode right) {
            this.val = val;
            this.left = left;
            this.right = right;
        }
        
    }
public class InvertBinaryTree {
    TreeNode root;
   
     void levelOrder(TreeNode root){
         if(root == null){
             return;
         }
         Queue<TreeNode> queue = new LinkedList<>();
         
         queue.add(root);
         while(!queue.isEmpty()){
            TreeNode current =  queue.poll();
             System.out.print(current.val+" ");
            if(current.left != null){
                queue.add(current.left);
            }
            if(current.right != null){
                queue.add(current.right);
            }
         }
     }
    TreeNode invertTree(TreeNode root) {
       if(root== null ){
           return null;
       }
       Queue<TreeNode> queue = new LinkedList<>();
       queue.add(root);
       while(!queue.isEmpty()){
           TreeNode current = queue.poll();
           // swap two children
           TreeNode temp = current.left;
           current.left = current.right;
           current.right = temp;
           
           if(current.left!= null){
           queue.add(current.left);
       }
           if(current.right != null){
               queue.add(current.right);
           }
           
           
       }
       return root;
    }
     
    public static void main(String[] args) {
        InvertBinaryTree obj = new InvertBinaryTree();
        obj.root = new TreeNode(4);
        obj.root.left = new TreeNode(2);
        obj.root.left.left = new TreeNode(1);
        obj.root.left.left = new TreeNode(1);
        obj.root.left.right = new TreeNode(3);
        obj.root.right = new TreeNode(7);
        obj.root.right.left = new TreeNode(6);
        obj.root.right.right = new TreeNode(9);
        System.out.println("");
        System.out.println(" Level traversal");
        obj.levelOrder(obj.root);
        System.out.println("");
       TreeNode current = obj.invertTree(obj.root);
        obj.levelOrder(current);
        System.out.println("");
    }
}


//Approach recursive way
//he time complexity of the invertTree function is O(N), where N is the number of nodes in the binary tree. 
//The space complexity of the invertTree function is O(N), where N is the height of the binary tree. 
//This is because the function makes recursive calls that consume memory on the call stack,
//and the maximum depth of the call stack is equal to the height of the binary tree.
/*  
class TreeNode{
        int val;
        TreeNode left;
        TreeNode right;

        public TreeNode() {
        }

        public TreeNode(int val) {
            this.val = val;
            
        }

        public TreeNode(int val, TreeNode left, TreeNode right) {
            this.val = val;
            this.left = left;
            this.right = right;
        }
        
    }
public class InvertBinaryTree {
    TreeNode root;
   
     void levelOrder(TreeNode root){
         if(root == null){
             return;
         }
         Queue<TreeNode> queue = new LinkedList<>();
         
         queue.add(root);
         while(!queue.isEmpty()){
            TreeNode current =  queue.poll();
             System.out.print(current.val+" ");
            if(current.left != null){
                queue.add(current.left);
            }
            if(current.right != null){
                queue.add(current.right);
            }
         }
     }
    TreeNode invertTree(TreeNode root) {
        if(root == null){
            return null;
        }
        TreeNode left = invertTree(root.left);
        TreeNode right = invertTree(root.right);
        root.left = right;
        root.right = left;
        return root;
    }
     
    public static void main(String[] args) {
        InvertBinaryTree obj = new InvertBinaryTree();
        obj.root = new TreeNode(4);
        obj.root.left = new TreeNode(2);
        obj.root.left.left = new TreeNode(1);
        obj.root.left.left = new TreeNode(1);
        obj.root.left.right = new TreeNode(3);
        obj.root.right = new TreeNode(7);
        obj.root.right.left = new TreeNode(6);
        obj.root.right.right = new TreeNode(9);
        System.out.println("");
        System.out.println(" Level traversal");
        obj.levelOrder(obj.root);
        System.out.println("");
       TreeNode current = obj.invertTree(obj.root);
        obj.levelOrder(current);
        System.out.println("");
    }
}
*/
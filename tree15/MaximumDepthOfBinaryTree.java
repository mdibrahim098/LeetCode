
package tree15;

import java.util.LinkedList;
import java.util.Queue;
//Approach 2 iterative way
 // time complexity O(n)
 // space complexity O(n)
public class MaximumDepthOfBinaryTree {
    TreeNode root;
     public static class  TreeNode{
    int val;
    TreeNode left;
    TreeNode right;

        public TreeNode() {
        }

        public TreeNode(int val) {
            this.val = val;
            this.right = null;
            this.left = null;
        }
    
}
   public int maxDepth(TreeNode root) {
        if (root == null){
            return 0;
        }
      Queue <TreeNode> queue = new LinkedList<>();
                queue.add(root);
              int height =1;
              while(true){
                  int levelNode = queue.size();
                  if(levelNode == 0){
                      return height;
                  }
                 
                  while(levelNode>0){
                       TreeNode current = queue.poll();
                       if(current.left != null){
                      queue.offer(current.left);
                  }
                  if(current.right != null){
                      queue.offer(current.right);
                  }
                 levelNode--;
                  }
                 height++;
              }
              
    }
   public void levelOreder(TreeNode root){
       if(root== null){
           return ;
       }
       Queue<TreeNode> queue = new LinkedList<>();
       queue.add(root);
        while(!queue.isEmpty()){
            TreeNode current = queue.poll();
            System.out.print(current.val+" ");
            if(current.left!= null){
                queue.offer(current.left);
            }
            if(current.right!= null){
                queue.offer(current.right);
            }
        }
        
       
   }
     public static void main(String[] args) {
        MaximumDepthOfBinaryTree obj = new MaximumDepthOfBinaryTree();
        obj.root = new TreeNode(3);
        obj.root.left = new TreeNode(9);
        obj.root.right = new TreeNode(20);
        obj.root.right.left = new TreeNode(15);
        obj.root.right.right = new TreeNode(7);
         System.out.println(" Level order traversal");
         obj.levelOreder(obj.root);
         System.out.println("");
         System.out.println(obj.maxDepth(obj.root));
         System.out.println("");
    }
}

//Approach 1 recursive way
//time complexity O(N)
//space complexity O(N)
// where N is the number of the nodes in the binary tree.
/* 
public class MaximumDepthOfBinaryTree {
    TreeNode root;
     public static class  TreeNode{
    int val;
    TreeNode left;
    TreeNode right;

        public TreeNode() {
        }

        public TreeNode(int val) {
            this.val = val;
            this.right = null;
            this.left = null;
        }
    
}
   public int maxDepth(TreeNode root) {
        if (root == null){
            return 0;
        }
        int lh = maxDepth(root.left);
        int rh = maxDepth(root.right);
        return 1 + Math.max(lh,rh);
    }
   public void levelOreder(TreeNode root){
       if(root== null){
           return ;
       }
       Queue<TreeNode> queue = new LinkedList<>();
       queue.add(root);
        while(!queue.isEmpty()){
            TreeNode current = queue.poll();
            System.out.print(current.val+" ");
            if(current.left!= null){
                queue.offer(current.left);
            }
            if(current.right!= null){
                queue.offer(current.right);
            }
        }
        
       
   }
     public static void main(String[] args) {
        MaximumDepthOfBinaryTree obj = new MaximumDepthOfBinaryTree();
        obj.root = new TreeNode(3);
        obj.root.left = new TreeNode(9);
        obj.root.right = new TreeNode(20);
        obj.root.right.left = new TreeNode(15);
        obj.root.right.right = new TreeNode(7);
         System.out.println(" Level order traversal");
         obj.levelOreder(obj.root);
         System.out.println("");
         System.out.println(obj.maxDepth(obj.root));
         System.out.println("");
    }
}

*/
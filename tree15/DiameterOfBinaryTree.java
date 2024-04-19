package tree15;




public class DiameterOfBinaryTree{
    TreeNode root;
    public static class TreeNode{
        int val;
        TreeNode left;
        TreeNode right;

        public TreeNode(int val) {
            this.val = val;
        }

        public TreeNode() {
        }
        
        
    }
  int result = -1;
  public int diameterOfBinaryTree(TreeNode root){
   dfs(root);
   return result;
      
  }
 
  public int dfs(TreeNode root){
      if(root == null){
          return -1;
      }
      int left = 1 + dfs(root.left);
      int right = 1 + dfs(root.right);
      result = Math.max(result,(left+right));
      return Math.max(left, right);
  }
    
    public static void main(String[] args) {
        DiameterOfBinaryTree obj = new DiameterOfBinaryTree();
        obj.root = new TreeNode(1);
        obj.root.left = new TreeNode(2);
        obj.root.left.left = new TreeNode(4);
        obj.root.left.right = new TreeNode(5);
         obj.root.right = new TreeNode(3);
         System.out.println(obj.diameterOfBinaryTree(obj.root));
    }
}

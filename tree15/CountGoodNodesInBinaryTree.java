package tree15;
// the time complexity of the algorithm is O(n)
//the space complexity is also O(n)
//where n is the total number of nodes in the binary tree.

public class CountGoodNodesInBinaryTree {

    Node root;

    public static class Node {

        int val;
        Node left;
        Node right;

        public Node() {
        }

        public Node(int val) {
            this.val = val;
        }

    }

    public int goodNodes(Node root) {
        return dfs(root, Integer.MIN_VALUE);

    }

    private int dfs(Node root, int max) {
        if (root == null) {
            return 0;
        }
         int result = root.val >= max ? 1:0;
//        int result;
//        if (root.val >= max) {
//            result = 1;
//        } else {
//            result = 0;
//        }
       
        result += dfs(root.left, Math.max(root.val, max));
        result += dfs(root.right, Math.max(root.val, max));
        return result;

    }

    public static void main(String[] args) {
        CountGoodNodesInBinaryTree obj = new CountGoodNodesInBinaryTree();
        obj.root = new Node(3);
        obj.root.left = new Node(1);
        obj.root.left.left = new Node(3);
        obj.root.right = new Node(4);
        obj.root.right.left = new Node(1);
        obj.root.right.right = new Node(5);
        System.out.println(obj.goodNodes(obj.root));

    }
}

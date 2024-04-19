package tree15;
//The time complexity of the isSubtree function is O(N * M), 
//where N is the number of nodes in the root tree,
//and M is the number of nodes in the subRoot tree. 
// space complexity O(N);
public class SubtreeOfAnotherTree {

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

    public static boolean isSubtree(Node root, Node subRoot) {
        if (subRoot == null || isSameTree(root, subRoot)) {
            return true;
        }
        if (root == null) {
            return false;

        }
        boolean left = isSubtree(root.left, subRoot);
        boolean right = isSubtree(root.right, subRoot);
        return left || right;
    }
    private static boolean isSameTree(Node root, Node subRoot){
        if(root == null && subRoot == null){
            return true;
        }
        if(root == null || subRoot == null){
             return false;
        }
        if( root.val != subRoot.val){
            return false;
        }
        boolean left = isSameTree(root.left, subRoot.left);
        boolean right = isSameTree(root.right, subRoot.right);
        return left && right;
    }

    public static void main(String[] args) {
        SubtreeOfAnotherTree obj1 = new SubtreeOfAnotherTree();
        obj1.root = new Node(1);
        obj1.root.left = new Node(2);
        obj1.root.right = new Node(3);
        obj1.root.left.left = new Node(4);
        obj1.root.left.right = new Node(5);
        obj1.root.right.right = new Node(6);

        SubtreeOfAnotherTree obj2 = new SubtreeOfAnotherTree();
        obj2.root = new Node(2);
        obj2.root.left = new Node(4);
        obj2.root.right = new Node(5);
        System.out.println(isSubtree(obj1.root, obj2.root));
    }
}

package tree15;
//Therefore, the time complexity is O(h)
//where h is the height of the BST.
// the space complexity is O(n) 
//h is the height of the BST.
public class LowestCommonAncestorOfABinarySearchTree {

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

    public Node lowestCommonAncestor(Node root, Node p, Node q) {
        if (root == null) {
            return null;
        }
        int current = root.val;
        if (current < p.val && current < q.val) {
            Node lca1 = lowestCommonAncestor(root.right, p, q);
            return lca1;
        }
        if (current > p.val && current > q.val) {
            Node lca2 = lowestCommonAncestor(root.left, p, q);
            return lca2;
        }
        return root;
    }

    public static void main(String[] args) {
        LowestCommonAncestorOfABinarySearchTree obj = new LowestCommonAncestorOfABinarySearchTree();
        Node root = obj.root = new Node(6);
        obj.root.left = new Node(2);
        obj.root.right = new Node(8);
        obj.root.right.left = new Node(7);
        obj.root.right.right = new Node(9);
        Node p = obj.root.left.left = new Node(0);
        obj.root.left.right = new Node(4);
        obj.root.left.right.left = new Node(3);
        Node q = obj.root.left.right.right = new Node(5);
        Node result = obj.lowestCommonAncestor(root, p, q);
        System.out.println(result.val);
    }
}

package tree15;


//Time complexity O(n)
//Space complexity O(n)
public class SameTree {

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

    private static boolean isSameTree(Node p, Node q) {
          if(p==null && q== null){
              return true;
          }
          if(p==null || q == null){
              return false;
          }
          if(p.val != q.val){
              return false;
          }
          boolean left = isSameTree(p.left,q.left);
          boolean right = isSameTree(p.right,q.right);
          return left && right;
    }

    public static void main(String[] args) {
        SameTree obj1 = new SameTree();
        obj1.root = new Node(1);
        obj1.root.left = new Node(2);
        obj1.root.right = new Node(3);
        obj1.root.right.left = new Node(4);
        obj1.root.right.right = new Node(5);
        SameTree obj2 = new SameTree();
        obj2.root = new Node(1);
        obj2.root.left = new Node(2);
        obj2.root.right = new Node(3);
        obj2.root.right.left = new Node(4);
        obj2.root.right.right = new Node(5);
        System.out.println(isSameTree(obj1.root,obj2.root));
    }
}

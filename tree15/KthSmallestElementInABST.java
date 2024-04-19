package tree15;

import java.util.LinkedList;
import java.util.List;

//Time complexity O(n)
//space complexity O(n)
//where n is the total number of nodes
public class KthSmallestElementInABST {
    Node root;
    public static class Node {
        int val ;
        Node left;
        Node right;

        public Node() {
        }

        public Node(int val) {
            this.val = val;
        }
        
    }
     public int kthSmallest(Node root, int k) {
     List<Integer> list = new LinkedList<>();
     inorder( root,list);
     return list.get(k-1);
    }
      private void inorder(Node root, List<Integer> list){
          if(root == null){
              return;
          }
              inorder(root.left , list);
              list.add(root.val);
              inorder(root.right , list);
          
      }
     public static void main(String[] args) {
        KthSmallestElementInABST obj = new KthSmallestElementInABST();
        obj.root = new Node(3);
        obj.root.right= new Node(3);
        obj.root.left = new Node(1);
        obj.root.left.right = new Node(2);
        int k =1;
         System.out.println(obj.kthSmallest(obj.root, k));
    }
}

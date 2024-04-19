package tree15;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.LinkedList;
import java.util.List;
import java.util.Queue;
//the time complexity of the algorithm is O(n),
//and the space complexity is also O(n), 
//where n is the total number of nodes in the binary tree.
public class BinaryTreeLevelOrderTraversal {

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

    public List<List<Integer>> levelOrder(Node root) {
       
        List<List<Integer>> result = new LinkedList<>();
        Queue<Node> queue = new LinkedList();
         if(root == null){
             return result;
        }
        queue.add(root);
        while(!queue.isEmpty()){
            List<Integer> level = new ArrayList<>();
            int n = queue.size();
            for(int i=0 ; i<n ;i++){
                 Node current = queue.poll();
                 level.add(current.val);
                 if(current.left != null){
                     queue.add(current.left);
                 }
                 if(current.right != null){
                     queue.add(current.right);
                 }
            }
            result.add(level);
           
        }
       return result;
    }

    public static void main(String[] args) {
        BinaryTreeLevelOrderTraversal obj = new BinaryTreeLevelOrderTraversal();
        obj.root = new Node(3);
        obj.root.left = new Node(9);
        obj.root.right = new Node(20);
        obj.root.right.left = new Node(15);
        obj.root.right.right = new Node(7);
        System.out.println(obj.levelOrder(obj.root));
    }
}

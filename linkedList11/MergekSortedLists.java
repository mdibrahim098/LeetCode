package linkedList11;

import java.util.Arrays;
import java.util.PriorityQueue;
//the time complexity is O(n log k),
//where n is the total number of nodes across all lists and k is the number of lists.
//the space complexity is O(k),
public class MergekSortedLists {
   public class ListNode{
        int val;
        ListNode next;
        public ListNode(){
            
        }

        public ListNode(int val) {
            this.val = val;
        }

        public ListNode(int val, ListNode next) {
            this.val = val;
            this.next = next;
        }
        
        
    }

    public ListNode mergeKLists(ListNode[] lists) {
        if (lists == null || lists.length == 0) {
            return null;
        }
        PriorityQueue<ListNode> queue = new PriorityQueue<>((a, b) -> a.val - b.val);
        for (ListNode node : lists) {
            if (node != null) {
                queue.offer(node);

            }
        }
            ListNode dummy = new ListNode(0);
            ListNode current = dummy;
            while (!queue.isEmpty()) {
             ListNode node = queue.poll();
                current.next = node;
                current = current.next;
                if (node.next != null) {
                    queue.offer(node.next);
                }

            }
            return dummy.next;

        }
    
    

    public static void main(String[] args) {
      MergekSortedLists obj = new MergekSortedLists();
        MergekSortedLists.ListNode[] lists = new MergekSortedLists.ListNode[]{
                obj.new ListNode(1, obj.new ListNode(4, obj.new ListNode(5))),
                obj.new ListNode(1, obj.new ListNode(3, obj.new ListNode(4))),
                obj.new ListNode(2, obj.new ListNode(6))
        };
        MergekSortedLists.ListNode mergedList = obj.mergeKLists(lists);
        // Print the merged list
        while (mergedList != null) {
            System.out.print(mergedList.val + " ");
            mergedList = mergedList.next;
        }
    }
}

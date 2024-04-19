package linkedList11;

import java.util.HashMap;
import java.util.Map;
//the time complexity is O(N)
//the space complexity is also O(N), 
//where N is the number of nodes in the original linked list.
 

class CopyListwithRandomPointer {
     public static  class ListNode {

    int val;
    ListNode next;
    ListNode random;

    ListNode(int value) {
        val = value;
        next = null;
        random = null;
    }
}

       static ListNode copyRandomList(ListNode head) {
        Map<ListNode, ListNode> map = new HashMap<>();
        ListNode temp = head;
//first iteration for inserting deep nodes of every node in the hashmap.
        while (temp != null) {
            ListNode newNode = new ListNode(temp.val);
            map.put(temp, newNode);
            temp = temp.next;
        }
        temp = head;
//second iteration for linking next and random pointer as given question.
        while (temp != null) {
            ListNode node = map.get(temp);
            node.next =  map.get(temp.next) ;
            node.random = map.get(temp.random) ;
            temp = temp.next;
        }
        return map.get(head);
    }

   static void printList(ListNode head) {
        while (head != null) {
            System.out.print(head.val + ":");
            if (head.next != null) {
                System.out.print(head.next.val);
            } else {
                System.out.print("NULL");
            }
            if (head.random != null) {
                System.out.print("," + head.random.val);
            } else {
                System.out.print(",NULL");
            }
            System.out.println();
            head = head.next;
        }
    }

    public static void main(String args[]) {
        ListNode head = null;

        ListNode node1 = new ListNode(1);
        ListNode node2 = new ListNode(2);
        ListNode node3 = new ListNode(3);
        ListNode node4 = new ListNode(4);

        head = node1;
        head.next = node2;
        head.next.next = node3;
        head.next.next.next = node4;

        head.random = node4;
        head.next.random = node1;
        head.next.next.random = null;
        head.next.next.next.random = node2;

        System.out.println("Original list:(current node:node pointed by next pointer node pointed by random pointer");
        printList(head);

        System.out.println("Copy list:(current node:node pointed by next pointer,node pointed by random pointer)");
        ListNode newHead = copyRandomList(head);
        printList(newHead);
    }
    
    
  
}

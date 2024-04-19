package linkedList11;

//time complexity O(n)
// space complexityO(1)
public class ReorderList {

    ListNode head;

    public class ListNode {

        int val;
        ListNode next;

        public ListNode() {

        }

        public ListNode(int val) {
            this.val = val;
        }

        public ListNode(int val, ListNode next) {
            this.val = val;
            this.next = next;
        }

    }

    public void addFirst(int val) {
        ListNode newNode = new ListNode(val);
        if (head == null) {
            head = newNode;
        } else {
            newNode.next = head;
            head = newNode;
        }
    }

    public void reorderList(ListNode head) {
        if (head == null || head.next == null || head.next.next == null) {
            return;
        }
        //Find middle of list using a slow and fast pointer approach
        ListNode slow = head;
        ListNode fast = head;
        while (fast != null && fast.next != null) {
            slow = slow.next;
            fast = fast.next.next;
        }

        //Reverse the second half of the list using a tmp variable
        ListNode current = slow.next;
        ListNode prev = null;
        while (current != null) {
            ListNode next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }

        slow.next = null;
        //Re-assign the pointers to match the pattern
        ListNode first = head;
        ListNode second = prev;
        while (second != null) {
            ListNode temp1 = first.next;
            ListNode temp2 = second.next;
            first.next = second;
            second.next = temp1;
            first = temp1;
            second = temp2;
        }
    }

    public static void main(String[] args) {
        ReorderList obj = new ReorderList();
        obj.addFirst(5);
        obj.addFirst(4);
        obj.addFirst(3);
        obj.addFirst(2);
        obj.addFirst(1);
        ListNode current = obj.head;
        while (current != null) {
            System.out.print(current.val + " ");
            current = current.next;
        }
        System.out.println("");
        obj.reorderList(obj.head);
        current = obj.head;
        while (current != null) {
            System.out.print(current.val + " ");
            current = current.next;
        }

    }
}

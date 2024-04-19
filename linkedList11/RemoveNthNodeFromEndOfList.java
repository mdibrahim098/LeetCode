package linkedList11;

//approach 2
// time complexity O(n)
// space complexity O(1)
public class RemoveNthNodeFromEndOfList {

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
            return;
        }
        newNode.next = head;
        head = newNode;

    }

    public ListNode removeNthFromEnd(ListNode head, int n) {
        // Create two pointers, fastp and slowp
        ListNode fastp = head;
        ListNode slowp = head;

        // Move the fastp pointer N nodes ahead
//        for (int i = 0; i < n; i++){
//              fastp = fastp.next;
//        }
        while (n > 0) {
            fastp = fastp.next;
            n--;
        }

        // If fastp becomes null, the Nth node from the end is the head
        if (fastp == null) {
            return head.next;
        }

        // Move both pointers until fastp reaches the end
        while (fastp.next != null) {
            fastp = fastp.next;
            slowp = slowp.next;
        }

        // Delete the Nth node from the end
//        ListNode delNode = slowp.next;
        slowp.next = slowp.next.next;
//        delNode = null;
        return head;

    }

    public static void main(String[] args) {
        RemoveNthNodeFromEndOfList obj = new RemoveNthNodeFromEndOfList();
        int n = 1;
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
        obj.head = obj.removeNthFromEnd(obj.head, n);
        System.out.println("");
        current = obj.head;
        while (current != null) {
            System.out.print(current.val + " ");
            current = current.next;
        }
    }
}

//Approach 1 brute force 
// time complexity O(n)
// space complexity O(1)
/*
public class RemoveNthNodeFromEndOfList {

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
           if(head==null){
               head = newNode;
               return;
           }
                newNode.next = head;
               head = newNode;
           
    }

    public ListNode removeNthFromEnd(ListNode head, int n) {
  if(head==null|| n==0){
            return head;
        }
    int count =0;
    ListNode temp = head;
     while(temp!=null ){
         count++;
         temp = temp.next;
         
     }
     
     if(count==n){
        head =head.next;
        return head;
     }
     int result = count -n;
   temp = head;
     while(temp!=null){
         result--;
         if(result==0){
             break;
         }
         temp = temp.next;
     }
 
     temp.next = temp.next.next;
     return head;
    }

    public static void main(String[] args) {
        RemoveNthNodeFromEndOfList obj = new RemoveNthNodeFromEndOfList();
        int n = 2;
        obj.addFirst(5);
        obj.addFirst(4);
        obj.addFirst(3);
        obj.addFirst(2);
        obj.addFirst(1);
        ListNode current = obj.head;
        while(current!=null){
            System.out.print(current.val+" ");
            current = current.next;
        }
        0bj.head = obj.removeNthFromEnd(obj.head, n);
        System.out.println("");
        current = obj.head;
        while(current!=null){
            System.out.print(current.val+" ");
            current = current.next;
        }
    }
}
 */

package linkedList11;



//Time complexity O(n)
//Space complexity O(1)
class LinkedListCycle {

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
    public void addFirst(int val){
        ListNode newNode = new ListNode(val);
        if(head==null){
            head = newNode;
        }else{
            newNode.next = head;
            head = newNode;
        }
    }

    public boolean hasCycle(ListNode head) {
        
     ListNode fastPtr = head;
     ListNode slowPtr = head;
     while(fastPtr!=null && slowPtr!=null && fastPtr.next != null){
         //advance both pointer
         slowPtr = slowPtr.next;
         fastPtr = fastPtr.next.next;
         
         //if they meet , means e found a loop
         if(fastPtr==slowPtr){
             return true;
         }
     }
     return false;
    }

    public static void main(String[] args) {
             LinkedListCycle obj = new LinkedListCycle();
             obj.addFirst(-4);
             obj.addFirst(0);
             obj.addFirst(2);
             obj.addFirst(3);
             obj.head.next.next.next.next = obj.head.next;
             
             System.out.println(obj.hasCycle(obj.head));
    }
}

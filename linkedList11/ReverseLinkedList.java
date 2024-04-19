package linkedList11;

class ListNode {
 ListNode head;
    int val;
    ListNode next;

    ListNode() {
    }

    ListNode(int val) {
        this.val = val;
    }

    ListNode(int val, ListNode next) {
        this.val = val;
        this.next = next;
    }
  public void addFirst(int val){
      ListNode newNode = new ListNode(val);
      if(head==null){
          head = newNode;
          return;
      }
      if(head!=null){
          newNode.next = head;
          head = newNode;
      }
      
  }
    public ListNode reverseList(ListNode head) {
      ListNode preNode = null;
      ListNode  currentNode = head;
   
      while(currentNode!=null){
         
         ListNode nextNode = currentNode.next;
         currentNode.next = preNode;
         preNode = currentNode;
         currentNode = nextNode;
          
      }
      head = preNode;
      return head;
    }

    public static void main(String[] args) {
        ListNode obj = new ListNode();

//        ListNode head = new ListNode(1);
//        head.next = new ListNode(2);
//        head.next.next = new ListNode(3);
//        head.next.next.next = new ListNode(4);
//        head.next.next.next.next = new ListNode(5);
//        ListNode reversed = obj.reverseList(head);

         obj.addFirst(5);
         obj.addFirst(4);
         obj.addFirst(3);
         obj.addFirst(2);
         obj.addFirst(1);
        obj.head = obj.reverseList(obj.head);
        ListNode current = obj.head;

        // Print the reversed list
        while (current!= null) {
            System.out.print(current.val + " ");
            current = current.next;
        }
    }
}






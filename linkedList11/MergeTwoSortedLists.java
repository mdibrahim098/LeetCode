package linkedList11;

//Time complexity:O(n+m)
//Space complexity: O(1)
public class MergeTwoSortedLists {
   ListNode head;
   class ListNode{
        int val;
        ListNode next;
       
        public ListNode(){
            
        }
        public ListNode(int val){
            this.val = val;
        }
        public ListNode(int val, ListNode next ){
            this.val = val;
            this.next = next;
        }
    }
   public void addFirst(int val){
       ListNode newNode = new ListNode(val);
       if(head==null){
          head = newNode;
          return;
       }
       
    
          newNode.next = head;
          head = newNode;
      
   }
   
     public ListNode mergeTwoLists(ListNode list1, ListNode list2) {
       ListNode dummyNode = new ListNode(Integer.MIN_VALUE); // Create a dummy node without a value
    ListNode headNode = dummyNode;

    while (list1 != null && list2 != null) {
        if (list1.val <= list2.val) {
            headNode.next = list1;
            list1 = list1.next;
        } else {
            headNode.next = list2;
            list2 = list2.next;
        }
        headNode = headNode.next; // Move the headNode pointer to the next node
    }

    // Connect the remaining nodes (if any) from list1 or list2
    if (list1 != null) {
        headNode.next = list1;
    } else {
        headNode.next = list2;
    }

    return dummyNode.next; // Return the next node after the dummy node
}
    
   
    public static void main(String[] args) {
        MergeTwoSortedLists list1 = new MergeTwoSortedLists();
       list1.addFirst(4);
       list1.addFirst(2);
       list1.addFirst(1);
        MergeTwoSortedLists list2 = new MergeTwoSortedLists();
       list2.addFirst(4);
       list2.addFirst(3);
       list2.addFirst(1);
        MergeTwoSortedLists margedList = new MergeTwoSortedLists();
         margedList.head = margedList.mergeTwoLists(list1.head, list2.head);
     
        ListNode current = margedList.head;
        while(current!=null){
            System.out.print(current.val+" ");
            current = current.next;
            
        }
    }
}

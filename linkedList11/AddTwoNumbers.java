package linkedList11;



 //the time complexity is O(max(N, M)) 
//and the space complexity is also O(max(N, M)), 
//where N and M are the lengths of the two input linked lists l1 and l2, respectively.
public class AddTwoNumbers {

         ListNode head;

    class ListNode {

        int val;
        ListNode next;

        public ListNode(int val, ListNode next) {
            this.val = val;
            this.next = next;
        }

        public ListNode(int val) {
            this.val = val;
        }

        public ListNode() {
        }

        public ListNode(ListNode next) {
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
    
    public ListNode addTwoNumbers(ListNode l1, ListNode l2) {
          
      
          ListNode t1 =l1;
          ListNode t2 =l2;
          ListNode dummy = new ListNode(Integer.MIN_VALUE);
          ListNode cur = dummy;
          int carry = 0;
          
          while(t1!=null || t2!=null){
            int  sum = carry;
            if(t1!=null){
                sum = sum + t1.val;
            }
            if(t2!=null){
                sum = sum + t2.val;
              
            }
            ListNode newNode = new ListNode(sum%10);
            cur.next = newNode;
            cur = cur.next;
            if(t1!=null){
                t1 = t1.next;
            }
            if(t2!=null){
                t2 = t2.next;
            }
            carry = sum/10;
          }
          
          if(carry>0){
               ListNode newNode = new ListNode(carry);
          cur.next = newNode;
        
          }
           return dummy.next;
    }

    public static void main(String[] args) {
      AddTwoNumbers obj = new AddTwoNumbers();
      obj.addFirst(3);
      obj.addFirst(4);
      obj.addFirst(2);
       AddTwoNumbers obj1 = new AddTwoNumbers();
      obj1.addFirst(4);
      obj1.addFirst(6);
      obj1.addFirst(5);
      ListNode current = obj.addTwoNumbers(obj.head, obj1.head);
      while(current!=null){
          System.out.print(current.val+" ");
          current = current.next;
      }
    }
}

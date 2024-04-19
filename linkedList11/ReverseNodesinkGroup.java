package linkedList11;

public class ReverseNodesinkGroup {

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
 
    public ListNode reverseKGroup(ListNode head, int k) {
               // Initialize a temporary
        // node to traverse the list
        ListNode temp = head;
        
        // Initialize a pointer to track the
        // last node of the previous group
        ListNode prevLast = null;
        
        // Traverse through the linked list
        while (temp != null) {
            
            // Get the Kth node of the current group
            ListNode kThNode = getKthNode(temp, k);
            
            // If the Kth node is NULL
            // (not a complete group)
            if (kThNode == null) {
               
                // If there was a previous group,
                // link the last node to the current node
                if (prevLast != null) {
                    prevLast.next = temp;
                }
                
                // Exit the loop
                break;
            }
            
            // Store the next node
            // after the Kth node
            ListNode nextNode = kThNode.next;
            
            // Disconnect the Kth node
            // to prepare for reversal
            kThNode.next = null;
            
            // Reverse the nodes from
            // temp to the Kth node
            reverseLinkedList(temp);
            
             // Adjust the head if the reversal
            // starts from the head
            if (temp == head) {
                head = kThNode;
            } else {
                // Link the last node of the previous
                // group to the reversed group
                prevLast.next = kThNode;
            }
            
            // Update the pointer to the
            // last node of the previous group
            prevLast = temp;
            
            // Move to the next group
            temp = nextNode;
        }
        
        // Return the head of the
        // modified linked list
        return head;
    }
    
    
    // Function to get the Kth node from
    // a given position in the linked list
   public ListNode getKthNode(ListNode temp, int k) {
        // Decrement K as we already
        // start from the 1st node
        k -= 1;
        
        // Decrement K until it reaches
        // the desired position
        while (temp != null && k > 0) {
            // Decrement k as temp progresses
            k--;
            
            // Move to the next node
            temp = temp.next;
        }
        
        // Return the Kth node
        return temp;
    }

      // Function to reverse a linked list
    // using the 3-pointer approach
   public ListNode reverseLinkedList(ListNode head) {
        // Initialize'temp' at
        // head of linked list
        ListNode temp = head;  
   
       // Initialize pointer 'prev' to NULL,
       // representing the previous node
       ListNode prev = null;  
       
       // Traverse the list, continue till
       // 'temp' reaches the end (NULL)
       while(temp != null){  
           // Store the next node in
           // 'front' to preserve the reference
           ListNode front = temp.next;  
           
           // Reverse the direction of the
           // current node's 'next' pointer
           // to point to 'prev'
           temp.next = prev;  
           
            // Move 'prev' to the current
            // node for the next iteration
           prev = temp;  
           
            // Move 'temp' to the 'front' node
            // advancing the traversal
           temp = front; 
       }
       
       // Return the new head of
       // the reversed linked list
       return prev;  

    }

    public static void main(String[] args) {
        ReverseNodesinkGroup obj = new ReverseNodesinkGroup();
        obj.addFirst(5);
        obj.addFirst(4);
        obj.addFirst(3);
        obj.addFirst(2);
        obj.addFirst(1);
        int k = 2;
        ListNode current = obj.reverseKGroup(obj.head, k);

        while (current != null) {
               System.out.print(current.val+" ");
               current = current.next;
        }
    }
}

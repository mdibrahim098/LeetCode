package linkedList11;

import java.util.HashMap;
import java.util.Map;
//Therefore, the overall time complexity of the get method is O(1).
//Therefore, the overall time complexity of the put method is O(1).
//Therefore, the space complexity is O(capacity) for the cache capacity 
//and O(n) for the number of entries in the hashmap, 
//where n represents the number of unique keys stored in the cache.
public class LRUCache {
  Map<Integer,Node> map = new HashMap<>();
    Node head = new Node(0, 0);
    Node tail = new Node(0, 0);
    int capacity;

    class Node {

        Node next;
        Node prev;
        int key;
        int value;

        public Node(int key, int value) {
            this.key = key;
            this.value = value;
        }

    }

    public LRUCache(int capacity) {
        this.capacity = capacity;
        head.next = tail;
        tail.prev = head;
    }

    public int get(int key) {
    if(map.containsKey(key)){
        Node node = map.get(key);
        remove(node);
        insert(node);
        return node.value;
    }else{
        return -1;
    }
    }

    public void put(int key, int value) {
          if(map.containsKey(key)){
              remove(map.get(key));
          }
          if(map.size()==capacity){
              remove(tail.prev);
          }
          insert(new Node(key,value));
    }
      private void remove(Node node){
        map.remove(node.key);
        node.prev.next = node.next;
        node.next.prev = node.prev;
    }
     private void insert(Node node){
        map.put(node.key, node);
        Node headNext = head.next;
        head.next = node;
        node.prev = head;
        node.next = headNext;
        headNext.prev = node;
        
    }

    public static void main(String[] args) {
        LRUCache obj = new LRUCache(2);
        obj.put(1, 1);
        obj.put(2, 2);
        System.out.println(obj.get(1));
        obj.put(3, 3);
        System.out.println(obj.get(2));
        obj.put(4, 4);
        System.out.println(obj.get(1));
        System.out.println(obj.get(3));
        System.out.println(obj.get(4));

    }
}

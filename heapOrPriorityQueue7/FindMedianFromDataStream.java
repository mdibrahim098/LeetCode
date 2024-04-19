
package heapOrPriorityQueue7;

import java.util.PriorityQueue;

//Time Complexity:
//addNum: O(log n)
//findMedian: O(1)
//Space Complexity: O(n)
class MedianFinder {
      PriorityQueue<Integer> maxHeap = new PriorityQueue<>((a,b)-> b - a);;
      PriorityQueue<Integer> minHeap = new PriorityQueue<>(); 
    public MedianFinder() {
        
    }
    
    public void addNum(int num) {
        if(maxHeap.isEmpty() || maxHeap.peek() >= num){
            maxHeap.add(num);
        }else{
            minHeap.add(num);
        }
        
        if(maxHeap.size() >minHeap.size()+1){
            minHeap.add(maxHeap.poll());
        }
        else if(maxHeap.size()<minHeap.size()){
            maxHeap.add(minHeap.poll());
        }
    }
    
    public double findMedian() {
        if(maxHeap.size() == minHeap.size()){
            return (maxHeap.peek()+minHeap.peek())/2.0;
        }else{
            return maxHeap.peek();
        }
        
    }
    public static void main(String[] args) {
        MedianFinder obj = new MedianFinder();
        obj.addNum(1);
        obj.addNum(2);
        System.out.println(obj.findMedian());
        obj.addNum(3);
        System.out.println(obj.findMedian());
    }
}


package heapOrPriorityQueue7;

//Time complexity O(n) where n is the number of tasks

import java.util.Arrays;

//Space complexity O(1);
public class TaskScheduler {
    
    public int leastInterval(char[] tasks, int n) {
        int[] freq = new int [26];
        for(char task :tasks){
            freq[task - 'A']++;
        }
        Arrays.sort(freq);
        int chunk = freq[25]-1;
        int idleSpot = chunk * n;
        for(int i =24; i>=0;i--){
            idleSpot-=Math.min(chunk, freq[i]);
        }
        return idleSpot <0? tasks.length : (tasks.length + idleSpot);
        
    }
    public static void main(String[] args) {
        TaskScheduler obj = new TaskScheduler();
      char []   tasks = {'A','A','A', 'B','B','B'};
         int n = 3;
         System.out.println(obj.leastInterval(tasks, n));
    }
}

package stack7;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Stack;
// Approach 2
//Time complexity: O(n)
//Space complexity: O(n)
public class DailyTemperatures {
      public int[] dailyTemperatures(int[] temperatures) {
        Stack<Integer> stack = new Stack<>();
         //initially all the value of array is 0        
        int [] result = new int [temperatures.length];
        for(int i = temperatures.length-1;i>=0;i--){
            while(!stack.isEmpty() && temperatures[stack.peek()]<=temperatures[i]){
                stack.pop();
            }
            if(!stack.isEmpty()){
                result[i]= stack.peek()-i;
            }
            stack.push(i);
        }
        return result;                                                                                           
      
    }
    public static void main(String[] args) {
        DailyTemperatures obj  = new DailyTemperatures();
        
         int [] temperatures = {73,74,75,71,69,72,76,73};
         System.out.println(Arrays.toString(obj.dailyTemperatures(temperatures)));
    }
}

//Approach 1
// Time complexity O(n^2)
//Space complexity O(n);

/*
public class DailyTemperatures {
      public int[] dailyTemperatures(int[] temperatures) {
        
          int count =0;
         int [] list = new int[temperatures.length];
          for(int i= 0;i<temperatures.length;i++){
              for(int j= i+1; j<temperatures.length;j++){
                  if(temperatures[i]<temperatures[j]){
                      count++;
                      break;
                  }else{
                      if(j== temperatures.length-1){
                          count =0 ;
                          break;
                      }
                      count++;
                      continue;
                  }
              }
             list[i] = count;
             count =0;
          }
         
         return list;
    }
    public static void main(String[] args) {
        DailyTemperatures obj  = new DailyTemperatures();
        
         int [] temperatures = {73,74,75,71,69,72,76,73};
         System.out.println(Arrays.toString(obj.dailyTemperatures(temperatures)));
    }
}

*/
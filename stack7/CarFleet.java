package stack7;

import java.util.Arrays;
import java.util.Comparator;

import java.util.Stack;

//Time complexity: O(n log n)
//Space complexity: O(n)
public class CarFleet {
      public int carFleet(int target, int[] position, int[] speed) {
          // If positon is equal to one means if there is only one car then car fleet is also one.
          if(position.length==1){
              return 1;
          }
        Stack<Double> stack = new Stack<>();
        // row = position.length because. The total number of car speed is always equal to the total number of car position.
        // coloum = 2 , represent car position and car speed.
        int [] [] combine = new int [position.length][2];
        for(int i=0; i<position.length; i++){
            combine[i][0]= position[i];
            combine [i][1] = speed[i];
        }
        // sorting the array based on the position. o[0] indicates the combine[][0].
        //If we dodn't sort them then our condition couldn't match.
      Arrays.sort(combine,Comparator.comparingInt(o->o[0]));
          //After sorting their index also will be changed. that's why we start iteration the last position of our 2D array.
          for(int i=position.length-1;i>=0;i--){
             double time = (double)(target-combine[i][0])/combine[i][1];
              if(!stack.isEmpty() && time<= stack.peek()){
                  continue;
              }else{
                  stack.push(time);
              }
          }
          return stack.size();
          
          
   
    }
    public static void main(String[] args) {
        CarFleet obj = new CarFleet();
        int target = 12;
        int [] position = {10,8,0,5,3};
        int[] speed = {2,4,1,1,3};
        System.out.println(obj.carFleet(target, position, speed));
    }
}

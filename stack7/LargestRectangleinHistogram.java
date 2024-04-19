package stack7;

//Approach 3
//Time complexity: O(n)
//Space complexity: O(n)
public class LargestRectangleinHistogram {

    public int largestRectangleArea(int[] heights) {
        int maxArea = 0;
        int[] left = new int[heights.length];
        int[] right = new int[heights.length];

        for (int i = 0; i < heights.length; i++) {
            int l = i;
            while (l >= 0 && heights[l] >= heights[i]) {
                l--;
            }
            left[i] = l;
        }

        for (int i = 0; i < heights.length; i++) {
            int r = i;
            while (r < heights.length && heights[r] >= heights[i]) {
                r++;
            }
          right[i]=r;
        }
        for(int i=0;i<heights.length;i++){
          maxArea = Math.max(maxArea, (right[i] - left[i] - 1) * heights[i]);  // Histogram area = (right -left -1) heights[i]
        }
     
        return maxArea;
    }

    public static void main(String[] args) {

        LargestRectangleinHistogram obj = new LargestRectangleinHistogram();
        int[] heights = {2, 1, 5, 6, 2, 3};

        System.out.println(obj.largestRectangleArea(heights));
    }

}

//Approach 2
//Time complexity: O(n)
//Space complexity: O(n)
/*
public class LargestRectangleinHistogram {

    public int largestRectangleArea(int[] heights) {
        int maxArea = 0;
        int[] left = new int[heights.length];
        int[] right = new int[heights.length];

        for (int i = 0; i < heights.length; i++) {
            int l = i;
            while (l >= 0 && heights[l] >= heights[i]) {
                l--;
            }
            left[i] = l;
        }

        for (int i = 0; i < heights.length; i++) {
            int r = i;
            while (r < heights.length && heights[r] >= heights[i]) {
                r++;
            }
          right[i]=r;
        }
        for(int i=0;i<heights.length;i++){
          maxArea = Math.max(maxArea, (right[i] - left[i] - 1) * heights[i]);  // Histogram area = (right -left -1) heights[i]
        }
     
        return maxArea;
    }

    public static void main(String[] args) {

        LargestRectangleinHistogram obj = new LargestRectangleinHistogram();
        int[] heights = {2, 1, 5, 6, 2, 3};

        System.out.println(obj.largestRectangleArea(heights));
    }

}
*/

//Approach 1
//Using Brute force algorithm
//Time complexity: O(n^2)
//Space complexity: O(1)

/*
public class LargestRectangleinHistogram {

    public int largestRectangleArea(int[] heights) {
      int maxArea = 0;
      for(int i=0; i<heights.length;i++){
          int left =i;
          int right =i;
          while(left>=0 && heights[left]>= heights[i]){
              left--;
          }
          while(right<heights.length && heights[right]>=heights[i]){
              right++;
          }
           maxArea = Math.max(maxArea, (right -left-1)*heights[i]);  // Histogram area = (right -left -1) heights[i]
      }
     return maxArea;
    }

    public static void main(String[] args) {

        LargestRectangleinHistogram obj = new LargestRectangleinHistogram();
   int[] heights = {2, 1, 5, 6, 2, 3};
      

        System.out.println(obj.largestRectangleArea(heights));
    }

}

 */


package binarySearch7;

// Approach 2
//the time complexity of the binary search algorithm is O(log(row * col)),
//which is equivalent to O(log n), where n is the total number of elements in the matrix.
//Space complexity: O(1)
public class SearchA2DMatrix {
        public boolean searchMatrix(int[][] matrix, int target) {
           if(matrix.length ==0){
               return false;
           }
           int row = matrix.length;
           int col = matrix[0].length; // matrix[0] means number of elements in the 0 row is the actual coloum size.
            int left = 0;
            int right = (row*col) -1;
            while(right>=left){
                int mid = (right+left)/2;
                if(matrix[mid/col][mid%col]==target){
                    return true;
                }else if(matrix[mid/col][mid%col]>target){
                    right= mid-1;
                }else{
                    left = left+1;
                }
            }
            return false;
    }
    
    public static void main(String[] args) {
     SearchA2DMatrix obj = new SearchA2DMatrix();
        
        int [][] matrix = {{1,3,5,7},{10,11,16,20},{23,30,34,60}};
         int target = 3;
         System.out.println(obj.searchMatrix(matrix, target));
    }
}

// Approach 1 
// Brute force metthod
// Time complexity O(m*n)
// space complexity O(1)
/*
public class SearchA2DMatrix {
        public boolean searchMatrix(int[][] matrix, int target) {
           for(int i=0;i<matrix.length;i++){
               for(int j=0;j<matrix.length;j++){
                   if(matrix[i][j]==target){
                       return true;
                   }
               }
           }
           return false;
    }
    
    public static void main(String[] args) {
     SearchA2DMatrix obj = new SearchA2DMatrix();
        
        int [][] matrix = {{1,3,5,7},{10,11,16,20},{23,30,34,60}};
         int target = 3;
         System.out.println(obj.searchMatrix(matrix, target));
    }
}

*/

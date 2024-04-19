

package binarySearch7;

//the time complexity is O(N log M).
//the space complexity is O(1).
public class KokoEatingBananas {
     public int minEatingSpeed(int[] piles, int h) {
          // Initalize the left and right boundaries
        int left = 1, right = 1;
        for (int pile : piles) {
            right = Math.max(right, pile);
        }

        while (left < right) {
            // Get the middle index between left and right boundary indexes.
            // hourSpent stands for the total hour Koko spends.
            int middle = (left + right) / 2;
            int hourSpent = 0;

            // Iterate over the piles and calculate hourSpent.
            // We increase the hourSpent by ceil(pile / middle)
            for (int pile : piles) {
                hourSpent += Math.ceil((double) pile / middle); // With double division operator return integer value so we casting double.
            }

            // Check if middle is a workable speed, and cut the search space by half.
            if (hourSpent <= h) {
                right = middle;
            } else {
                left = middle + 1;
            }
        }

        // Once the left and right boundaries coincide, we find the target value,
        // that is, the minimum workable eating speed.
        return right;
    }
    
    
    public static void main(String[] args) {
        KokoEatingBananas obj = new KokoEatingBananas();
        
        int [] piles = {3,6,7,11};
         int h = 8;
         System.out.println(obj.minEatingSpeed(piles, h));
    }
}

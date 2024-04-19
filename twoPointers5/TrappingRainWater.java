package twoPointers5;



//the time complexity of the code is O(n)
//the space complexity is also O(n).
public class TrappingRainWater {

    public int trap(int[] height) {
        int[] maxLeft = new int[height.length];
        int[] maxRight = new int[height.length];
        maxLeft[0] = height[0];
        maxRight[height.length - 1] = height[height.length - 1];
        for (int i = 1; i < height.length; i++) {
            maxLeft[i] = Math.max(maxLeft[i - 1], height[i]);
        }
        for (int i = height.length - 2; i >= 0; i--) {
            maxRight[i] = Math.max(maxRight[i + 1], height[i]);
        }
        int result = 0;
        for (int i = 0; i < height.length; i++) {
            result += (Math.min(maxLeft[i], maxRight[i])) - (height[i]);
        }
        return result;
    }

    public static void main(String[] args) {
        TrappingRainWater obj = new TrappingRainWater();
        int[] height = {0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1};
        System.out.println(obj.trap(height));
    }

}

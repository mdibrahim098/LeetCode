package twoPointer;

import java.util.Arrays;

//TC O(n+m)
//SC O(1)
public class MergeSortedArray {

    public void merge(int[] nums1, int m, int[] nums2, int n) {
       int i = m-1;
       int j = n-1;
       int k = m+n-1;
       while(j>=0){
           if(i>= 0 && nums1[i] > nums2[j]){
               nums1[k--] = nums1[i--];
           }else{
               nums1[k--] = nums2[j--];
           }
       }
        
        System.out.println(Arrays.toString(nums1));
    }

    public static void main(String[] args) {
        MergeSortedArray obj = new MergeSortedArray();
        int[] nums1 = {1, 2, 3, 0, 0, 0};
        int m = 3;
        int[] nums2 = {2, 5, 6};
        int n = 3;
        obj.merge(nums1, m, nums2, n);
        System.out.println();
    }
}




//approach 1
//TC O((n+m)log(n+m))
//SC O(1)
/*
public class MergeSortedArray {

    public void merge(int[] nums1, int m, int[] nums2, int n) {
        int j = m;
        for (int i = 0; i < n; i++) {
            nums1[j] = nums2[i];
            j++;

        }
        Arrays.sort(nums1);
        System.out.println(Arrays.toString(nums1));
    }

    public static void main(String[] args) {
        MergeSortedArray obj = new MergeSortedArray();
        int[] nums1 = {1, 2, 3, 0, 0, 0};
        int m = 3;
        int[] nums2 = {2, 5, 6};
        int n = 3;
        obj.merge(nums1, m, nums2, n);
        System.out.println();
    }
}
*/
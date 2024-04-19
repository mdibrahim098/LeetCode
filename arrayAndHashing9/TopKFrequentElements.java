package arrayAndHashing9;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class TopKFrequentElements {

    public int[] topKFrequent(int[] nums, int k) {
        //Counting Frequencies:
        Map<Integer, Integer> map = new HashMap<>();
        for (int num : nums) {
            if (map.containsKey(num)) {
                map.put(num, map.get(num) + 1);

            } else {
                map.put(num, 1);
            }

        }
        //Sorting by Frequency:
        List<Integer> list = new ArrayList<>(map.keySet());
        Collections.sort(list, (a, b) -> map.get(b) - map.get(a));
        //Building Result Array:
        int[] result = new int[k];
        int index = 0;
        for (int i = 0; i < k; i++) {
            result[index] = list.get(i);
            index++;

        }
        return result;
    }

    public static void main(String[] args) {
        TopKFrequentElements obj = new TopKFrequentElements();
        int[] nums = {1, 1, 1, 2, 2, 3};
        int k = 2;
        System.out.println(Arrays.toString(obj.topKFrequent(nums, k)));
    }
}

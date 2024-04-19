package backtracking9;

import java.util.ArrayList;
import java.util.List;
//Time Complexity: O(N×2^N) where N is the length of the input string
//Space Complexity: O(N×2^N)

public class PalindromePartitioning {

    public List<List<String>> partition(String s) {
        List<List<String>> ans = new ArrayList<>();
        List<String> ds = new ArrayList<>();
        func(0, s, ans, ds);
        return ans;
    }

    private void func(int index, String s, List<List<String>> ans, List<String> ds) {
        if (index == s.length()) {
            ans.add(new ArrayList<>(ds));
            return;
        }
        for (int i = index; i < s.length(); i++) {
            if (isPalindrome(s, index, i)) {
                ds.add(s.substring(index, i + 1));
                func(i + 1, s, ans, ds);
                ds.remove(ds.size() - 1);
            }
        }
    }

    private boolean isPalindrome(String s, int start, int end) {
        while (start <= end) {
            if (s.charAt(start++) != s.charAt(end--)) {
                return false;
            }
        }
        return true;
    }

    public static void main(String[] args) {
        PalindromePartitioning obj = new PalindromePartitioning();
        String s = "aab";
        System.out.println(obj.partition(s));
    }
}

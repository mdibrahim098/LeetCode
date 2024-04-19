package stack7;

import java.util.ArrayList;
import java.util.List;
//Time complexity: O(4^n )
//Space complexity: O(4^n )
public class GenerateParentheses {

    public List<String> generateParenthesis(int n) {
        List<String> result = new ArrayList<>();
        backtracking(result,"",0,0,n);
        return result;
    }
    
    private void backtracking(List<String> result, String currentS, int open, int close, int n){
        if(currentS.length() == n*2){
            result.add(currentS);
            return;
        }else{
            if(open<n){
                backtracking(result,currentS+"(",open+1,close,n);
            }
            if(close<open){
                backtracking(result,currentS+")",open,close+1,n);
            }
        }
    }

    public static void main(String[] args) {
        GenerateParentheses obj = new GenerateParentheses();
        int n = 3;
        System.out.println(obj.generateParenthesis(n));
    }
}

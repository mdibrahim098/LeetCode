using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEETCODE128
{
    class Minimum_Add_to_Make_Parentheses_Valid
    {

        public int MinAddToMakeValid(string s)
        {
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    stack.Push('(');
                }
                else if (s[i] == ')')
                {
                    // Check if the stack is not empty and the top of the stack is an opening parenthesis
                    if (stack.Count > 0 && stack.Peek() == '(')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        // Otherwise, push the closing parenthesis onto the stack
                        stack.Push(')');
                    }
                }
            }

            return stack.Count;
        }
        //static void Main(string[] args)
        //{
        //    Minimum_Add_to_Make_Parentheses_Valid obj = new Minimum_Add_to_Make_Parentheses_Valid();
        //    string s = s = "())";
        //    Console.WriteLine(obj.MinAddToMakeValid(s));
        //}
    }
}

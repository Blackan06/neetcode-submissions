public class Solution {
    public bool IsValid(string s) {
        //Ý tưởng: Gặp ký tự mở $\rightarrow$ Push vào stack. Gặp ký tự đóng $\rightarrow$ Pop ra kiểm tra xem có khớp loại không.
        Stack<char> stack = new Stack<char>();
        foreach (char c in s) {
            if (c == '(') stack.Push(')'); 
            else if (c == '{') stack.Push('}');
        else if (c == '[') stack.Push(']');
        else if (stack.Count == 0 || stack.Pop() != c) return false;           
        }
        return stack.Count == 0;
    }
}

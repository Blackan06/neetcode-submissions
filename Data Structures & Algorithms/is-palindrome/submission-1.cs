public class Solution {
    public bool IsPalindrome(string s) {
        int left = 0 ;
        int right = s.Length - 1;

        while(left < right){
            while(left < right && !char.IsLetterOrDigit(s[left]))
            {
                left++;
            }
            while(left < right && !char.IsLetterOrDigit(s[right]))
            {
                right--;
            }
            
            char.ToLower(s[left]);
            char.ToLower(s[right]);
            Console.WriteLine(left);
            Console.WriteLine(right);
            Console.WriteLine(s[left]);
            Console.WriteLine(s[right]);
            if (char.ToLower(s[left]) == char.ToLower(s[right])) {
                left++;
                right--;
            }else{
                return false;
            }
        }

        return true;

    }
}

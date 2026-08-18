public class Solution {
    public bool IsPalindrome(string s) {
        //Đầu tiên : Khai báo index i = 0 và j = s.length - 1
        //Thứ 2: Ta dùng hàm for để duyệt và đối chiếu vị trí của i và j 
        // Thứ 3 : Nếu gía trị ở thứ tự không đảm bảo thì false
        //Clean chuoi s 
        StringBuilder sb = new StringBuilder();

        foreach(var c in s){
            if(char.IsLetterOrDigit(c)){
                sb.Append(char.ToLower(c));
            }
        }
        s = sb.ToString();
        int i = 0; 
        int j = s.Length - 1;


        while(i < j){
            if(s[i] == s[j]){
                i++;
                j--;
            }else if(s[i] != s[j]){
                return false;
            }

        }
        return true;
    }
}

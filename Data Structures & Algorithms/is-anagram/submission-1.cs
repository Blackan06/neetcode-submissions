public class Solution {
    public bool IsAnagram(string s, string t) {
        //dau tien check ky tu trong chuoi s
        // neu chuoi s la racecar
        //thi se bao gom r = 2 , a=2 va c = 1 e =1 
        // neu t co tuong tu nhu vay thi true
        //nguoc lai la false
        if (s.Length != t.Length) return false;
        // Buoc 1 khoi tao dictionary 
        Dictionary<char,int> dictC = new Dictionary<char,int>();
        foreach(var c in s){
            if (dictC.ContainsKey(c)) {
                dictC[c]++;
            }else{
                dictC[c] = 1;
            }
        }

        foreach(var c in t) {
            // Nếu chuỗi t chứa ký tự không có trong s, 
            // hoặc ký tự đó đã bị trừ hết (số lượng = 0) -> False
            if (!dictC.ContainsKey(c) || dictC[c] == 0) {
                return false;
            }
            dictC[c]--; // Trừ đi 1
        }

        return true;
    }
}

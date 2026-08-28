public class Solution {
    public bool IsAnagram(string s, string t) {
        //dau tien check ky tu trong chuoi s
        // neu chuoi s la racecar
        //thi se bao gom r = 2 , a=2 va c = 1 e =1 
        // neu t co tuong tu nhu vay thi true
        //nguoc lai la false
        if (s.Length != t.Length) return false;
        // Buoc 1 khoi tao dictionary 
        Dictionary<char, int> dc = new Dictionary<char,int>();
        //Buoc 2 : luu cac ky tu vao dc cua chuoi s
        foreach(var c in s){
            if(dc.ContainsKey(c)){
                dc[c] += 1;
            }else{
                dc[c] = 1;
            }
        }
        // Buoc 3 check 
        foreach(var c in t){
            if (!dc.ContainsKey(c) || dc[c] == 0)
            {
                return false;
            }
            dc[c] -= 1;
        }

        return true;
    }
}

public class Solution {

    public string Encode(IList<string> strs) {
        //Đề bài yêu cầu mã hoá  
        //Đầu tiên tạo StringBuilder
        StringBuilder sb = new StringBuilder();
        //Sau đó sẽ duyệt từng phần tử trong mảng
        foreach(var str in strs){
            sb.Append(str.Length).Append('#').Append(str);
        }

        return sb.ToString();
    }

    public List<string> Decode(string s) {
        List<string> res = new List<string>();
        int i = 0;
        while(i < s.Length){
            int j = i;
            while(s[j] != '#'){
                j++;
            }

            int length = int.Parse(s.Substring(i, j-i));
            res.Add(s.Substring(j+1,length));
            i = j+1+ length;
        }
        return res;
   }
}

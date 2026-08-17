public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var map = new Dictionary<string,List<string>>();
        foreach(var str in strs){
            // 1. Tạo mảng 26 phần tử đại diện cho 26 chữ cái (a-z)
            // Trong C#, kiểu char có thể lưu trữ số nguyên lên tới 65,535
            // nên ta dùng char[] để đếm thay vì int[] để dễ dàng convert sang string làm Key.
            char[] count = new char[26];
            foreach(var c in str){
                count[c - 'a']++;
            }
            string key = new string(count);

            if(!map.TryGetValue(key, out var list)){
                list = new List<string>();
                map[key] = list;
            }

            list.Add(str);
        }
        return map.Values.ToList();
    }
}

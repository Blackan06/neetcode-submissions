public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        //Tạo dc để check so sánh và return 
       Dictionary<string , List<string>> dc = new Dictionary<string, List<string>>();

       //Tạo mảng để duyệt từng phần tử
       foreach(var s in strs){
            //Chuyển str sang char để sort 
            char[] chars = s.ToCharArray();
            //Sort 
            Array.Sort(chars);
            //Khởi tạo key để lưu vào dc để so sánh 
            string key = new string(chars);
            // Nếu như key không có trong dc
            if(!dc.ContainsKey(key)){
                //thì tạo key mới trong dc
                dc[key] = new List<string>();
            }
            //Sau đó add value 
            dc[key].Add(s);
       }

       return dc.Values.ToList();
    }   
}

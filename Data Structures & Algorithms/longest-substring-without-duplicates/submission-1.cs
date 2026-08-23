public class Solution {
    public int LengthOfLongestSubstring(string s) {
        // 1. Tạo HashSet để chứa các ký tự trong "cửa sổ" hiện tại
        HashSet<char> window = new HashSet<char>();
        
        int left = 0;
        int maxLength = 0;
        
        // 2. Con trỏ 'right' đi mở rộng cửa sổ sang phải
        for(int right = 0; right < s.Length; right++) {
            char currentChar = s[right];
            
            // 3. XỬ LÝ VI PHẠM (Thu hẹp cửa sổ từ bên trái)
            // Lặp lại việc xóa chữ và nhích 'left' lên cho đến khi 
            // chữ currentChar KHÔNG CÒN nằm trong HashSet nữa.
            while(window.Contains(currentChar)) {
                window.Remove(s[left]); 
                left++;
                // ??? (Bạn sẽ cần gõ lệnh xóa chữ ở vị trí 'left' khỏi HashSet ở đây)
                
                // ??? (Và nhích con trỏ 'left' lên 1 bước ở đây)
            }
            
            // 4. THÊM VÀO CỬA SỔ (Lúc này chắc chắn an toàn, không còn trùng lặp)
            window.Add(currentChar);
            
            // 5. CẬP NHẬT KỶ LỤC 
            // (Độ dài cửa sổ hiện tại luôn là: right - left + 1)
            maxLength = Math.Max(maxLength, right - left + 1);
        }
        
        return maxLength;
    }
}
public class Solution {
    public string MinWindow(string s, string t) {
        if (s.Length < t.Length || t == "") return "";

        // 1. Khởi tạo mảng ASCII 128 phần tử (bao gồm cả hoa, thường, đặc biệt)
        int[] countT = new int[128];
        int[] window = new int[128];
        
        // Đếm các ký tự cần thiết trong t
        int need = 0; // Đếm xem có bao nhiêu LOẠI chữ cái cần thỏa mãn
        foreach (char c in t) {
            if (countT[c] == 0) need++; // Nếu là chữ cái mới thì tăng số lượng loại cần tìm
            countT[c]++;
        }

        int left = 0;
        int have = 0; // Đã gom đủ bao nhiêu loại chữ cái
        
        // Hai biến để lưu vết chuỗi ngắn nhất
        int minLength = int.MaxValue;
        int startIndex = -1;

        // MỞ RỘNG CỬA SỔ BÊN PHẢI
        for (int right = 0; right < s.Length; right++) {
            char rightChar = s[right];
            window[rightChar]++; // Đưa ký tự vào cửa sổ

            // Nếu ký tự này nằm trong t và số lượng vừa gom ĐÚNG BẰNG số lượng cần
            if (countT[rightChar] > 0 && window[rightChar] == countT[rightChar]) {
                have++; // Đánh dấu đã gom đủ 1 loại chữ cái
            }

            // THU HẸP CỬA SỔ BÊN TRÁI (Khi đã gom đủ tất cả các loại chữ cái cần thiết)
            while (have == need) {
                // Cập nhật kỷ lục ngắn nhất hiện tại
                if (right - left + 1 < minLength) {
                    minLength = right - left + 1;
                    startIndex = left; // Nhớ lại vị trí bắt đầu để lát cắt chuỗi
                }

                // Bắt đầu loại bỏ ký tự ở mép trái
                char leftChar = s[left];
                window[leftChar]--;

                // Nếu ký tự bị vứt đi nằm trong t, và số lượng tụt xuống dưới mức cần thiết
                if (countT[leftChar] > 0 && window[leftChar] < countT[leftChar]) {
                    have--; // Đánh mất trạng thái "đủ chỉ tiêu"
                }

                left++; // Co mép trái lại
            }
        }

        // Nếu startIndex vẫn là -1 tức là không tìm thấy
        return minLength == int.MaxValue ? "" : s.Substring(startIndex, minLength);
    }
}
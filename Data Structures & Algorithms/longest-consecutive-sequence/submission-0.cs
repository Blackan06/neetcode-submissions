public class Solution {
    public int LongestConsecutive(int[] nums) {
        // Đơn giản : duyệt 2 mangr là xong
        // Nhưng O(n)
        // đầu tiên : tạo biến List
        // Sau đó tìm số min của nums  
        // rồi duyệt từng phần tử và check số nào lớn hơn 1 đơn vị thì import các số lớn hơn nums
// Xử lý trường hợp ngoại lệ: Nếu mảng rỗng thì độ dài chuỗi là 0
        if (nums == null || nums.Length == 0) {
            return 0;
        }        
        HashSet<int> hashSet = new HashSet<int>(nums);

        int maxLength = 0; // Biến lưu kỷ lục chuỗi dài nhất
        foreach (int num in hashSet) {
            // DẤU HIỆU: Nếu số liền trước (num - 1) KHÔNG tồn tại, 
            // thì 'num' chính là số bắt đầu của một chuỗi.
            if (!hashSet.Contains(num - 1)) {
                int currentNum = num;
                int currentStreak = 1;

                while (hashSet.Contains(currentNum + 1)) {
                    currentNum++;
                    currentStreak++;
                }

                // Cập nhật kỷ lục nếu chuỗi vừa đếm dài hơn kỷ lục cũ
                if (currentStreak > maxLength) {
                    maxLength = currentStreak;
                }
            }
        }
        return maxLength;
    }
}

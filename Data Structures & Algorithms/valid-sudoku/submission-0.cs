public class Solution {
    public bool IsValidSudoku(char[][] board) {
        // Bước 1.  Khai báo 3 cột đó là row, cols, boxes
        // Dùng hash để tối ưu code Time(O(1)) và Space(O(N))

        HashSet<char>[] cols = new HashSet<char>[9];
        HashSet<char>[] rows = new HashSet<char>[9];
        HashSet<char>[] boxes = new HashSet<char>[9];

        //Khởi tạo từng hashset trong mảng 
        for (int i = 0; i < 9; i++) {
            cols[i] = new HashSet<char>();
            rows[i] = new HashSet<char>();
            boxes[i] = new HashSet<char>();
        }

        //Bước 2 : Chạy vòng lặp để xác định vị trí 
        // Sau đó kiểm tra vị trí đó trống hay có số (Có số bỏ qua)
        // Nếu không thì kiểm tra xem có trùng hay không nếu chưa thì thêm vào  
        for (int i = 0; i < 9; i++) {
            for (int j = 0; j < 9; j++) {         
                char val = board[i][j]; // Nhấc con số tại ô hiện tại lên
                // Nếu là ô trống (dấu '.') thì bỏ qua, đi sang ô tiếp 
                //theo
                if (val == '.') {
                    continue;
                }
                // BƯỚC QUAN TRỌNG: Xác định mã số khu vực 3x3 (từ 0 đến 
                //8)
                int position = (i / 3) * 3 + (j / 3);

                if(rows[i].Contains(val) || cols[j].Contains(val) || boxes[position].Contains(val)){
                    return false;
                }

                rows[i].Add(val);
                cols[j].Add(val);
                boxes[position].Add(val);
            }
        }
        return true;
    }
}

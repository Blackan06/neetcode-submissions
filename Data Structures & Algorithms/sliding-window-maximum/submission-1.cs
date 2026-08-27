public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        int[] result = new int[nums.Length - k + 1];

        LinkedList<int> deque = new LinkedList<int>();

        for(int right = 0; right < nums.Length ; right++)
        {
            // --- QUY TẮC 1: ĐUỔI KẺ HẾT THỜI (Ma cũ) ---
            // Nếu kẻ đang đứng ĐẦU võ đài (số Max) có vị trí nằm ngoài 
            //mép 
            //trái của cửa sổ
            // -> Hết nhiệm kỳ, đuổi cổ hắn ra khỏi cửa TRƯỚC của võ đài.
            if(deque.Count > 0 && deque.First.Value < right - k + 1){
                deque.RemoveFirst();
            }
            // Tai sao while ma khong phai if
            while(deque.Count > 0 && nums[deque.Last.Value] < nums[right]){
                deque.RemoveLast();
            }

            deque.AddLast(right);

            if(right >= k - 1){
                result[right - k + 1] = nums[deque.First.Value];
            }
        }
        return result;
    }
}

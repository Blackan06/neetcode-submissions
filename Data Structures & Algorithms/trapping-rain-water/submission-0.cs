public class Solution {
    public int Trap(int[] height) {
        // Khởi tạo i và j
        int left = 0;
        int right = height.Length - 1;
        int maxleft = 0;
        int maxright = 0;
        var totalwater  = 0;

        while(left < right){
            if(height[left] < height[right]){
                maxleft = Math.Max(maxleft, height[left]);
                totalwater += maxleft - height[left];
                left++;
            }else{
                maxright = Math.Max(maxright, height[right]);
                totalwater += maxright - height[right];
                right--;
            }
        }

        return totalwater;
    }
}

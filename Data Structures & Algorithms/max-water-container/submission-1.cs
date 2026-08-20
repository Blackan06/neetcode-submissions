public class Solution {
    public int MaxArea(int[] heights) {
        //Đầu tiên xác định được khoảng cách vách ngăn (i và j) 
       // V = h x w
        int i = 0; 
        int j = heights.Length - 1;
        int maxArea = 0;
        while(i < j){
            int width = j - i;
            int minHeight = Math.Min(heights[i], heights[j]);
            int currentArea = minHeight * width;
            maxArea = Math.Max(maxArea, currentArea);
            if(heights[i] < heights[j]){
                i++;
            }else{
                j--;
            }
           
       }
       return maxArea;
    }
}
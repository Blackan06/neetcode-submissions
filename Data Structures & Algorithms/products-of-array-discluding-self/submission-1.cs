public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] newNums = new int[nums.Length];
        newNums[0] = 1;
        for(int i = 1 ; i < nums.Length ; i++){
            newNums[i] = newNums[i-1] * nums[i-1];
        }

        int right = 1;
        for(int i = nums.Length - 1 ; i >= 0 ; i--){
            newNums[i] *= right;
            right *= nums[i];
        }

        return newNums;
    }
}

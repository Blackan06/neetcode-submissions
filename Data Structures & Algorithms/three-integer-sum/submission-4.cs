public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        List<List<int>> a = new List<List<int>>();
        for(int i = 0; i < nums.Length; i++){
            if(i > 0 && nums[i] == nums[i -1]){
                continue;
            }
            int left = i + 1;
            int right = nums.Length - 1;

           while(left < right){
                if(nums[i] + nums[left] + nums[right] > 0){
                    right--;
                }else if (nums[i] + nums[left] + nums[right] < 0){
                    left++;
                }else{
                    a.Add([nums[i],nums[left],nums[right]]);
                    left++;
                    right--;
                    while(left < right && nums[left] == nums[left-1]){
                        left++;
                    }
                }
           }

        }
        return a;
    }
}

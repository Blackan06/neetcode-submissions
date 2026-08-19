public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        // Đầu tiên , Khai báo i = 0 , j = i+ 1 và k = nums.Length - 1
        // Duyệt vòng lặp với chiều dài nums.Length - 3 vì chừa chỗ cho k và j
        // Sắp xếp trước khi vào vòng lặp 

        // Nếu sum = 0 thì cứ tăng j và giảm k
        // Nếu sum > 0 thì giảm k
        // Nếu sum < 0 thì tăng j

        //Tao moi list 
        List<List<int>> newList = new List<List<int>>();

        // Sort nums
        Array.Sort(nums);
        for(int i = 0;i < nums.Length - 2; i++){
            // NÉ TRÙNG LẶP CHO i: Nếu số này giống số trước đó, bỏ qua chạy tiếp
            if (i > 0 && nums[i] == nums[i - 1]) {
                continue;
            }
            
            // 3. Reset j và k ở mỗi vòng lặp mới của i
            int j = i + 1; 
            int k = nums.Length - 1;
            while(j < k){
                 var sum = nums[i] + nums[j] + nums[k];
                if(sum == 0){
                    newList.Add(new List<int> { nums[i], nums[j], nums[k] 
                    });
                    while(j < k && nums[j] == nums[j + 1]) j++;
                    while(j < k && nums[k] == nums[k - 1]) k--;                
                    j++;
                    k--;
                }
                else if (sum < 0){
                    j++;
                }else{
                    k--;
                }
            }
        }

        return newList;
    }
}

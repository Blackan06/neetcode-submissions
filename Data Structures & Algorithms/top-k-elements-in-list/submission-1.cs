public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        // Dau tien khoi tao dictionary<int,int>
        var dict = new Dictionary<int,int>();

        foreach(var num in nums){
            if(!dict.ContainsKey(num)){
                dict[num] = 0;
            }else{
                dict[num]++;
            }
        }
        // Bước 2: Dùng Min-Heap để giữ K phần tử lớn nhất
        // PriorityQueue<Phần_tử, Độ_ưu_tiên>
        var pq = new PriorityQueue<int, int>();
        foreach(var pair in dict){
            pq.Enqueue(pair.Key, pair.Value);

            if(pq.Count > k){
                pq.Dequeue();
            }
        }
        int[] result = new int[k];
        for(int i = k - 1; i >= 0 ; i--){
            result[i] = pq.Dequeue();
        }

        return result;

    }
}

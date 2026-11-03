public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> counters = new Dictionary<int,int>();

        for (int i = 0; i < nums.Length; i++) 
        {
            if(!counters.ContainsKey(nums[i]))
                counters.Add(nums[i], 0);
            
            counters[nums[i]]++;
        }

        return counters.OrderByDescending(x => x.Value).Take(k)
            .ToDictionary(x => x.Key, x => x.Value)
            .Keys.ToArray();

        

    }
}

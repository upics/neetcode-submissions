public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        
        List<List<int>> res = new List<List<int>>();
        Array.Sort(nums);

        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] > 0) break;
            int key = i;
            int val = nums[i];

            if (key > 0 && val == nums[key - 1])
                continue;

            int l = i + 1;
            int r = nums.Length - 1;

            while (l < r)
            {
                int sum = val + nums[l] + nums[r];

                if (sum > 0)
                    r--;
                else if (sum < 0)
                    l++;
                else
                {
                    res.Add(new List<int>(){
                        val, nums[l], nums[r]
                    });
                    l++;
                    while (nums[l] == nums[l - 1] && l < r)
                        l++;
                }
            }
        }

        return res;
    }
}

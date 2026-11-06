public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] res = new int[nums.Length];
        if (nums.Length <= 0 )
            return [];
        
        int zeroCount = 0;
        bool foundNonZero = false;

        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] != 0)
                foundNonZero = true;
            else
                zeroCount++;
        }

        if (zeroCount > 1)
            return new int[nums.Length];

        int totProduct = foundNonZero ? 1 : 0;

        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] != 0)
                totProduct *= nums[i];
        }

        for (int i = 0; i < res.Length; i++) {
            res[i] = nums[i] == 0 ? totProduct : (zeroCount > 0 ? 0 : totProduct / nums[i]);
        }

        return res;
    }
}

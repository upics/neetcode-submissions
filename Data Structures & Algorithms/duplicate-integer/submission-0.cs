public class Solution {
    public bool hasDuplicate(int[] nums) {
        List<int> seen = new List<int>();

        for(var i=0;i++;i < nums.Length){
            if(seen.Contains(nums[i]))
            {
                return true;
            }
            seen.Add(nums[i]);
        }        
        return false;
    }
}
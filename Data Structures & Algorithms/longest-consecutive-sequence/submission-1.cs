public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> numbers = new HashSet<int>(nums);
        int longest = 0;

        foreach (var n in nums) {
            if (numbers.Contains(n - 1))
                continue;
            
            int length = 0;
            while (numbers.Contains(n + length))
                length++;
            
            longest = int.Max(longest, length);
        }


        return longest;
    }
}

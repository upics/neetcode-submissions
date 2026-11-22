public class Solution {
    public int LengthOfLongestSubstring(string s) {

        HashSet<char> chars = new HashSet<char>();
        int l = 0;
        int result = 0;
        for (int r = 0; r < s.Length; r++) {
            while(chars.Contains(s[r]))
            {
                chars.Remove(s[l]);
                l++;
            }

            chars.Add(s[r]);
            result = Math.Max(result, r - l + 1);
        }

        return result;

    }
}

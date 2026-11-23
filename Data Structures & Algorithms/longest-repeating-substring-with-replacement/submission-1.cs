public class Solution {
    public int CharacterReplacement(string s, int k) 
    {
        Dictionary<char,int> occ = new Dictionary<char,int>();

        int l = 0;
        int result = 0;
        for (int r = 0; r < s.Length; r++) {
            occ[s[r]] = 1 + occ.GetValueOrDefault(s[r], 0);

            if ((r-l+1) - occ.Values.Max() > k)
            {
                occ[s[l]]--;
                l++;
            }
            result = Math.Max(result, r - l + 1);
        }

        return result;
    }
}

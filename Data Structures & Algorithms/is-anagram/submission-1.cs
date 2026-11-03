public class Solution {
    public bool IsAnagram(string s, string t) {

        if (s.Length != t.Length)
            return false;

        Char[] sArray = s.ToCharArray();
        Char[] tArray = t.ToCharArray();

        Dictionary<char, int> count = new Dictionary<char,int>();

        for (int i = 0; i < sArray.Length; i++) {
            count[sArray[i]] = count.GetValueOrDefault(sArray[i], 0) + 1;
            count[tArray[i]] = count.GetValueOrDefault(tArray[i], 0) - 1;
        }

        bool any = !count.Values.Any(x => x != 0);

        return any;
    }
}

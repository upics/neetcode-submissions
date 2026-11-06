public class Solution {

    public string Encode(IList<string> strs) {
        string result = String.Empty;
        foreach (var item in strs) {
            result += $"{item.Length}#{item}";
        }

        return result;
    }

    public List<string> Decode(string s) {
        List<string> result = new List<string>();

        int i = 0;
        while (i < s.Length)
        {
            // 123456#ssssss1234567#qqqqqqq
            int hashIndex = s.IndexOf("#", i);
            int sLenght = int.Parse(s.Substring(i, hashIndex - i));
            result.Add(s.Substring(hashIndex + 1, sLenght));
            i = hashIndex + 1 + sLenght;
        }
            
        return result;
   }
}

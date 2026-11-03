public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> output = new Dictionary<string, List<string>>();

        foreach(var word in strs)
        {
            Char[] chars = word.ToCharArray();
            Array.Sort(chars);
            string key = new string(chars);

            if(!output.ContainsKey(key))
                output.Add(key, new List<string>());
            
            output[key].Add(word);
        }

        return output.Values.ToList();
    }
}
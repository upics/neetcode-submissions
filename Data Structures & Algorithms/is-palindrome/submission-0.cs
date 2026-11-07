public class Solution {
    public bool IsPalindrome(string s) {
        
        Char[] word = s.ToCharArray();
        int l = 0;
        int r = word.Length - 1;

        while (l <= r)
        {
            while (l < r && !IsAlphaNumeric(word[l]))
            {
                l++;
            }

            while (r > l && !IsAlphaNumeric(word[r]))
            {
                r--;
            }

            if (Char.ToLower(word[l]) != Char.ToLower(word[r]))
                return false;

            l++;
            r--;            
        }
        return true;

    }

    private bool IsAlphaNumeric(Char c)
    {
        return (('A'<= c && c <= 'Z') ||
                ('a' <= c && c <= 'z') ||
                ('0' <= c && c <= '9'));
    }
}

public class Solution {
    public int MaxArea(int[] heights) {
        int height = 0;
        int width = 0;

        int l = 0;
        int r = heights.Length - 1;
        int result = 0;

        while (l < r)
        {
            height = Math.Min(heights[l], heights[r]);
            width = (r - l);

            result = Math.Max(result, height * width);

            if(heights[l] < heights[r])
                l++;
            else
                r--;
        }
        return result;
    }
}

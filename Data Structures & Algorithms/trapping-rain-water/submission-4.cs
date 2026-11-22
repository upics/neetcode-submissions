public class Solution {
    public int Trap(int[] height) {
        int l = 0;
        int r = height.Length - 1;
        int leftMax = height[l];
        int rightMax = height[r];
        int tot = 0;

        while (l < r)
        {
            if (leftMax < rightMax)
            {
                l++;
                leftMax = Math.Max(leftMax, height[l]);
                tot += leftMax - height[l];
            }
            else
            {
                r--;
                rightMax = Math.Max(rightMax, height[r]);
                tot += rightMax - height[r];   
            }
        }
        return tot;
    }
}

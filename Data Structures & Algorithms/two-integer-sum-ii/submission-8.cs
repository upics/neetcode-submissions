public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        Dictionary<int, int> selected = new Dictionary<int,int>();
        for (int i = 0; i < numbers.Length; i++) 
        {
            int searchedValue = target - numbers[i];
            if(selected.ContainsKey(searchedValue))
            {
                return new int[]{selected[searchedValue] + 1, i+1};
            }
            selected[numbers[i]] = i;
        }

        return [];
    }
}

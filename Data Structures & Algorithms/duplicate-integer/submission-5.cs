public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int, int> dictionary = [];

        foreach (var num in nums) {
            dictionary[num] = dictionary.GetValueOrDefault(num) + 1;
        }

        foreach (var pair in dictionary) {
            if (pair.Value > 1) {
                return true;
            }
        }
        return false;
    }
}
public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var dictionary = new Dictionary<int, int>();

for (int i = 0; i < nums.Length; i++)
{
    int key = nums[i];
    if (dictionary.ContainsKey(key))
    {
        return true;
    }
    dictionary[key]=i;
}
return false;
    }
}
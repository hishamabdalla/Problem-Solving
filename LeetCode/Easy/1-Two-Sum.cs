public class Solution {
     public int[] TwoSum(int[] nums, int target)
     {
        var table=new Dictionary<int,int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int complated=target-nums[i];

            if (table.ContainsKey(complated))
            {
                return new int[] { table[complated],i };
            }

            table[nums[i]] = i;
        }
        return new int[] { };
    }
}
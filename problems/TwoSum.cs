using System.Collections.Generic;

public class TwoSum {
  public int[] Solve(int[] nums, int target) {
    var dict = new Dictionary<int, int>();

    for (int i=0; i<nums.Length; i++) {
      if (dict.ContainsKey(target - nums[i])) {
        return new[] { dict[target - nums[i]], i };
      }
      dict[nums[i]] = i;
    }
    return System.Array.Empty<int>();
  }
}
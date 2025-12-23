using System;

public static class TwoSumTests {
  public static void Run(){
    var sol = new TwoSum();

    Test(sol.Solve(new[] {2,7,11,15}, 9), "[0,1]");
    Test(sol.Solve(new[] {3,2,4}, 6), "[1,2]");
  }

  static void Test(int[] actual, string expected) {
    var result = $"[{actual[0]},{actual[1]}]";
    Console.WriteLine(result == expected ? "PASS" : "FAIL");
  }
}
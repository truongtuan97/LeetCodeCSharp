using System;

public class ReverseStringTests {
  public static void Run() {
    var solver = new ReverseString();

    Test(solver, new[] {'h','e','l','l','o'}, "olleh");
    Test(solver, new[] {'H','a','n','n','a','h'}, "hannaH");
    Test(solver, new[] {'a','d','n','s','t','h'}, "dsdsada");
  }

  static void Test(ReverseString solver, char[] input, string expected) {
    solver.Solve(input);
    var result = new String(input);
    Console.WriteLine(result == expected ? "✅ PASS" : $"❌ FAIL → {result}");
  }
}
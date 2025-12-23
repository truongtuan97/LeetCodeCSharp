using System;

public static class ReverseWordsTests {
    public static void Run() {
        var solver = new ReverseWords();

        Test(solver, "Let's take LeetCode contest",
             "s'teL ekat edoCteeL tsetnoc");

        Test(solver, "God Ding", "doG gniD");

        TestWithSpan(solver, "Let's take LeetCode contest",
             "s'teL ekat edoCteeL tsetnoc");

        TestWithSpan(solver, "God Ding", "doG gniD");
    }

    static void Test(ReverseWords solver, string input, string expected) {
        var result = solver.Solve(input);
        Console.WriteLine(result == expected ? "✅ PASS" : $"❌ FAIL → {result}");
    }

    static void TestWithSpan(ReverseWords solver, string input, string expected) {
        var result = solver.SolveWithSpan(input);
        Console.WriteLine(result == expected ? "✅ PASS" : $"❌ FAIL → {result}");
    }
}

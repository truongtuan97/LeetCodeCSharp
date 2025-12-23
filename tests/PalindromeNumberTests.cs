using System;

public static class PalindromeNumberTests {
    public static void Run() {
        var solver = new PalindromeNumber();

        Test(solver, 121, true);
        Test(solver, -121, false);
        Test(solver, 10, false);
        Test(solver, 0, true);
        Test(solver, 12321, true);
    }

    static void Test(PalindromeNumber solver, int input, bool expected) {
        var result = solver.IsPalindrome(input);
        Console.WriteLine(result == expected ? "✅ PASS" : $"❌ FAIL → {input}");
    }
}

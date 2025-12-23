using System;
using System.Collections.Generic;

public static class FizzBuzzTests {
  public static void Run(){
    var fb = new FizzBuzz();

    Test(fb.Solve(3), "[1,2,Fizz]");
    Test(fb.Solve(5), "[1,2,Fizz,4,Buzz]");
    Test(fb.Solve(15), "[1,2,Fizz,4,Buzz,Fizz,7,8,Fizz,Buzz,11,Fizz,13,14,FizzBuzz]");
  }

  static void Test(IList<string> actual, string expected) {
    var result = "[" + string.Join(",", actual) + "]";
    Console.WriteLine(result == expected ? "PASS" : $"FAIL -> {result}");
  }
}
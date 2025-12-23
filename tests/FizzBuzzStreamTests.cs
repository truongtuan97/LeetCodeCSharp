public static class FizzBuzzStreamTests {
  public static void Run(){
    var fb = new FizzBuzzStream();

    Console.WriteLine("First 15 mins: ");
    int count = 0;

    foreach (var s in fb.Stream(1, int.MaxValue)) {
      Console.WriteLine(s);
      if (++count == 15) break;
    }
  }
}
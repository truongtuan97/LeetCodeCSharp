using System.Collections.Generic;
using System.Text;

public class FizzBuzzStream {
  public IEnumerable<string> Stream(int start, int end) {
    for (int i=start; i<= end; i++) {
      var sb = new StringBuilder();

      if (i%3==0) sb.Append("Fizz");
      if (i%5==0) sb.Append("Buzz");

      yield return sb.Length == 0 ? i.ToString() : sb.ToString();
    }
  }
}
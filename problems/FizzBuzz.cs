using System.Collections.Generic;
using System.Text;

public class FizzBuzz {
  public IList<string> Solve(int n) {
    var result = new List<string>(n);

    for (int i=1; i<=n; i++) {
      var sb = new StringBuilder();

      if (i%3==0) sb.Append("Fizz");
      if (i%5==0) sb.Append("Buzz");

      result.Add(sb.Length == 0 ? i.ToString() : sb.ToString());
    }
    return result;
  }
}
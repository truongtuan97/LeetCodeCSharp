public class ReverseWords {
  public string Solve(string s) {
    var chars = s.ToCharArray();
    int start = 0;

    for (int i=0; i<=chars.Length; i++) {
      if (i == chars.Length || chars[i] == ' ') {
        Reverse(chars, start, i-1);
        start = i+1;
      }
    }
    return new string(chars);
  }

  public string SolveWithSpan(string s) {
    var chars = s.ToCharArray();
    Span<char> span = chars;

    int start = 0;
    for (int i=0; i<=span.Length; i++) {
      if (i == span.Length || span[i] == ' ') {
        span[start..i].Reverse();
        start = i+1;
      }
    }
    return new string(chars);
  }

  private void Reverse(char[] arr, int left, int right) {
    while (left < right) {
      (arr[left], arr[right]) = (arr[right], arr[left]);
      left++;
      right--;
    }
  }
}
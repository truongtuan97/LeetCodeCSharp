public static class ThreeSumTests {
  public static void Run() {
    var solver = new ThreeSum();
    
    var input = new[] { -1, 0, 1, 2, -1, -4 };
    IList<IList<int>> expected = new List<IList<int>> {
      new List<int> { -1, -1, 2 },
      new List<int> { -1, 0, 1 }
    };

    var result = solver.Solve(input);

    bool pass = AreEqual(result, expected);
    Console.WriteLine(pass ? "✅ PASS" : "❌ FAIL");
  }

  static bool AreEqual(IList<IList<int>> a, IList<IList<int>> b) {
    var na = Normalize(a);
    var nb = Normalize(b);

    if (na.Count != nb.Count) return false;

    for (int i=0; i<na.Count; i++) {
      if (!na[i].SequenceEqual(nb[i])) {
        return false;
      }
    }
    return true;
  }

  static List<List<int>> Normalize(IList<IList<int>> input) {
    return input
      .Select(t => t.OrderBy(x => x).ToList())
      .OrderBy(t => string.Join(",", t))
      .ToList();
  }
}
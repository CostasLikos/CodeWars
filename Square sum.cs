using System;
using System.Linq;
public static class Kata
{
  public static int SquareSum(int[] numbers) => numbers.Select(n => n * n).Sum();
}

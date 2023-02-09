using System;
using System.Linq;

public class Kata
{
  public static int SquareDigits(int n)=> int.Parse(string.Join("", n.ToString().Select(x => (x - '0') * (x - '0'))));
}

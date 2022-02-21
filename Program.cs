using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public static class Problem
    {
        public static string CamelCase(this string str)
        {
            Console.WriteLine(str);
            return str == "" ? "" : string.Join("", str.Trim().Split(" ").Where(word => !string.IsNullOrWhiteSpace(word)).Select(word => char.ToUpper(word[0]) + word.Substring(1)).ToArray());
            //you can still execute the programm with " "
        }
    }
}

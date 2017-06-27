using System.Linq;
using System.Text.RegularExpressions;

namespace Exercises
{
    public static class StringExtensions
    {
        public static string ExcludePunctuations(this string value)
        {
            return Regex.Replace(value, @"[\W_]", string.Empty);
        }

        public static string Reversed(this string value)
        {
            return string.Join(" ", value.Split(' ').Reverse());
        }
    }
}

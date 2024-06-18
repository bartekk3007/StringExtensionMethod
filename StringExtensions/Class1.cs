using System.Runtime.CompilerServices;

namespace StringExtensions
{
    public static class Extensions
    {
        public static string AppendExclamation(this string str)
        {
            return str + "!";
        }
    }
}

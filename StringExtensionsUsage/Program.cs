using StringExtensions;

namespace StringExtensionsUsage
{
    public class Program
    {
        static void Main(string[] args)
        {
            string name = "Bartek";
            string appendedName = name.AppendExclamation();
            Console.WriteLine(appendedName);
        }
    }
}

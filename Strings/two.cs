
using System.Text;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

//2 задача

namespace Strings
{
    public class Program
    {
        public static void Main()
        {
            string s1 = "\"Welcome\"";
            string s2 = "\"to\"";
            string s3 = "\"the\"";
            string s4 = "\"TMS\"";
            string s5 = "\"lessons.\"";
            string[] finish = new string[] { s1, s2, s3, s4, s5 };

            string s0 = string.Join(" ", finish);
            Console.WriteLine(s0);
        }
    }
}
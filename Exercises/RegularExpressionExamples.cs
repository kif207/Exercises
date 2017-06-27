using System;
using System.Text.RegularExpressions;

namespace Exercises
{
    /*
     * https://msdn.microsoft.com/en-us/library/system.text.regularexpressions.regex(v=vs.110).aspx
     * https://docs.microsoft.com/en-us/dotnet/standard/base-types/regular-expression-language-quick-reference
     * https://www.dotnetperls.com/regex
     * https://docs.microsoft.com/en-us/dotnet/standard/base-types/regular-expression-examples
     */
    class RegularExpressionExamples
    {
        // Extract a Protocol and Port Number from a URL
        // https://docs.microsoft.com/en-us/dotnet/standard/base-types/how-to-extract-a-protocol-and-port-number-from-a-url

        public static void ExtractProtocolAndPort()
        {
            string url = "http://www.contoso.com:8080/letters/readme.html";

            Regex r = new Regex(@"^(?<proto>\w+)://[^/]+?(?<port>:\d+)?/",
                                RegexOptions.None, TimeSpan.FromMilliseconds(150));

            Match m = r.Match(url);
            if (m.Success)
                Console.WriteLine(r.Match(url).Result("${proto}${port}"));
        }
        //https://docs.microsoft.com/en-us/dotnet/standard/base-types/regular-expression-example-scanning-for-hrefs
        public static void ScanHREFs(string inputString)
        {
            Match m;
            string HRefPattern = "href\\s*=\\s*(?:[\"'](?<1>[^\"']*)[\"']|(?<1>\\S+))";

            try
            {
                m = Regex.Match(inputString, HRefPattern,
                                RegexOptions.IgnoreCase | RegexOptions.Compiled,
                                TimeSpan.FromSeconds(1));
                while (m.Success)
                {
                    Console.WriteLine("Found href " + m.Groups[1] + " at "
                       + m.Groups[1].Index);
                    m = m.NextMatch();
                }
            }
            catch (RegexMatchTimeoutException)
            {
                Console.WriteLine("The matching operation timed out.");
            }
        }

        //https://docs.microsoft.com/en-us/dotnet/standard/base-types/regular-expression-example-changing-date-formats
        public static string ChangeDateFormats(string input)
        {
            try
            {
                return Regex.Replace(input,
                      "\\b(?<month>\\d{1,2})/(?<day>\\d{1,2})/(?<year>\\d{2,4})\\b",
                      "${day}-${month}-${year}", RegexOptions.None,
                      TimeSpan.FromMilliseconds(150));
            }
            catch (RegexMatchTimeoutException)
            {
                return input;
            }
        }

        // https://docs.microsoft.com/en-us/dotnet/standard/base-types/how-to-strip-invalid-characters-from-a-string

        public static string StripInvalidCharacters(string strIn)
        {
            // Replace invalid characters with empty strings.
            try
            {
                return Regex.Replace(strIn, @"[^\w\.@-]", "",
                                     RegexOptions.None, TimeSpan.FromSeconds(1.5));
            }
            // If we timeout when replacing invalid characters, 
            // we should return Empty.
            catch (RegexMatchTimeoutException)
            {
                return String.Empty;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Strings
    {
        public static void permutation(String str)
        {
            permutation(str, "");
         }

        static void permutation(String str, String prefix)
        {
            if (str.Length == 0)
            {
             Console.Write(prefix);
            }
            else
            {
               for (int i = 0; i < str.Length; i++)
                {
                    String rem = str.Substring(0, i) + str.Substring(i + 1);
                    permutation(rem, prefix + str[i]);
                    }
                }
            }
    }
}

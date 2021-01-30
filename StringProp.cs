using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work12Jan
{
    class StringProp
    {
        static void Main()
        {
            var ch = new char[] { 'M', 'O', 'R', 'E' };
            String s1 = new string(ch);
            Console.WriteLine(s1);

            //strings are immutable
            //3 obj is created n use more memory
            string a1 = "hello ";
            a1 += "Siri ";
            a1 += "Good ";
            a1 += "Girl";
            Console.WriteLine(a1);
            //degrades performance so instead use "StringBuilder"

            //only one obj is created
            StringBuilder sb = new StringBuilder();
            sb.Append("Hi ");
            sb.Append("David ");
            sb.Append("Smith ");
            Console.WriteLine(sb);

            //Imp to copyTo()
            StringBuilder src = new StringBuilder("AI");
            //destination to store string
            var dest = new char[src.Length];
            //using CopyTo()
            src.CopyTo(0,dest,0,src.Length);
            Console.WriteLine(dest);


        }
    }
}

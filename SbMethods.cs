using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work12Jan
{
    class SbMethods
    {
        static void Main()
        {
            char ch = 'y';
            StringBuilder sb = new StringBuilder();
            //1.Append
            sb.Append("This ");
            sb.Append("is ");
            sb.Append("Siri!! ");
            Console.WriteLine("String is: "+ sb);

            //2.AppendLine-append a str with the newline char at the end.
            sb.AppendLine("C# Programming");
            Console.WriteLine("Appends with str is: "+ sb);

            Console.WriteLine("Menu Driven Program for *STRINGBUILDER METHODS* ");
            while (ch == 'y')
            {
                //ListOfMethods
                Console.WriteLine("1.Replace");
                Console.WriteLine("2.CopyTo");
                Console.WriteLine("3.Remove");
                Console.WriteLine("4.LengthOfName");
                Console.WriteLine("5.EXIT");

                Console.WriteLine("Enter your choice");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        sb.Replace("This", "She");
                        Console.WriteLine(sb);
                        break;

                    case 2:
                        StringBuilder src = new StringBuilder("Hello Ai\n");
                        //destination to store string
                        var dest = new char[src.Length];
                        //using CopyTo()
                        src.CopyTo(0, dest, 0, src.Length);
                        Console.WriteLine(dest+"\n");
                        break;

                    case 3:
                        StringBuilder s1 = new StringBuilder("C#Programming", 10);
                        // after 5th index- 3 letters are removed 
                        s1.Remove(5, 4);//gram
                        Console.WriteLine($"We get output as : {s1}\n");
                        break;

                    case 4:
                        StringBuilder s2 = new StringBuilder("C# is easy");
                        Console.WriteLine($"Length of Statement: {s2.Length}\n");
                        break;

                    case 5:
                        Console.WriteLine("Exit Application\n");
                        ch = 'n';
                        break;

                    default:
                        Console.WriteLine("Invalid Input\n");
                        break;
                }
            }
        }
    }
}

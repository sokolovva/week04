using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoiningStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter separator: ");
            string sep = Console.ReadLine();
            Console.WriteLine(JoinString(sep,"petya", "asd", "lala","haha"));



        }
        static string JoinString (string separator, params string [] strings)
        {
            string joinedString = string.Join(separator, strings);
            return joinedString;
        }
    }
}

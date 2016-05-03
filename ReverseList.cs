using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackBulgaria4
{
    class ReverseList
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
          


        }
        static void ReversedList(List<int> list1)
        {
            string number = null;
            while ((number = Console.ReadLine()) != string.Empty)
            {
                list1.Add(int.Parse(number));
            }
        }
    }
}

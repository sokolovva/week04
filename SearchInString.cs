using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchInString
{
    class SearchInString
    {
        static void Main(string[] args)
        {
            Console.Write("Words: ");
            List<string> list1 = new List<string>();
          
            string words = null;
            while ((words = Console.ReadLine()) != string.Empty)
            {
                list1.Add(words);
            }
            Console.Write("Enter the word for searching: ");
            string wordForSearch = Console.ReadLine();
            int found;
            Console.WriteLine(TryFindSubstring(list1, wordForSearch,out found);
            
        }
        static bool TryFindSubstring(List<string> list, string searched, out int found)
        {
            
            int counter = 0;
            foreach (var item in list)
            {
              
                if (item==searched)
                {
                    counter++;
                    
                   
                }
            }


            
        }
    }
    
}

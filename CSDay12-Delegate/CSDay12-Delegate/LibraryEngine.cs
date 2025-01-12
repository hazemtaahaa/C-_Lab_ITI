using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDay12_Delegate
{
    public class LibraryEngine
    {
        public static void ProcessBooks(List<Book> bList, Func<Book, string> fPtr)
        {
            foreach (Book item in bList)
            {
                Console.WriteLine(fPtr(item));
            }
        }
        public static List<Book> ProcessBooksBool(List<Book> bList, Func<Book, bool> fPtr)
        {
            List<Book> filteredBooks = new List<Book>();

            foreach (Book item in bList)
            {
               
                if (fPtr(item))
                {
                    filteredBooks.Add(item); 
                }
            }

            return filteredBooks;
        }
    }
}

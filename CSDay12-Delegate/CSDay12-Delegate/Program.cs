using static System.Reflection.Metadata.BlobBuilder;

namespace CSDay12_Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region  Anonymous Method (GetISBN)

             LibraryEngine.ProcessBooks(Repository.books, delegate (Book B) { return B.ISBN; });


            #endregion


            #region  Lambda Expression (GetPublicationDate)

            //print books with Lambda Expression

            //LibraryEngine.ProcessBooks(Repository.books, B => B.ToString());

            /*--------------------------------------------------*/

            //List<Book> booksBefore2000 = LibraryEngine.ProcessBooksBool(Repository.books, B => B.PublicationDate.Year < 2000);
            //Console.WriteLine("Books published before 2000:");
            //foreach (var book in booksBefore2000)
            //{
            //    Console.WriteLine(book);
            //}


            /*--------------------------------------------------*/

            //List<Book> booksWithTowAouthr = LibraryEngine.ProcessBooksBool(Repository.books, B => B.Authors.Length > 1);
            //Console.WriteLine("Books With more than one Aouthr:");
            //foreach (var book in booksWithTowAouthr)
            //{
            //    Console.WriteLine(book);
            //}



            /*--------------------------------------------------*/

            // LibraryEngine.ProcessBooks(Repository.books, B => B.Title);
            #endregion



        }
    }
}

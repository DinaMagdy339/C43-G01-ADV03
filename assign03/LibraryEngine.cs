using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign03
{
    #region a
    internal delegate string BookFunctionDelegate(Book book);

	#endregion  
    internal class LibraryEngine
    {
        #region a
        public static void ProcessBooksUserDefinedDelegate(List<Book> bList, BookFunctionDelegate fPtr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr(B));
            }
        } 
        #endregion

        #region b
        public static void ProcessBooksBCLDelegates(List<Book> bList, Func<Book, string> fPtr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr(B));
            }
        }
        #endregion

        #region c
        public static void ProcessBooksAnonymousMethod(List<Book> bList)
        {
            foreach (Book B in bList)
            {
                Func<Book, string> fPtr = delegate (Book b)
                {
                    return b.ISBN;
                };
                Console.WriteLine(fPtr(B));
            }
        }
        #endregion

        #region d
        public static void ProcessBooksLambdaExpression(List<Book> bList)
        {
            foreach (Book B in bList)
            {
                Func<Book, string> fPtr = b => b.PublicationDate.ToShortDateString();
                Console.WriteLine(fPtr(B));
            }
        } 
        #endregion
    }
}

namespace assign03 
{
    internal class Program 
    {
        public static void Main(string[] args) 
        {
            List<Book> Books = new List<Book>
        {
            new Book("112277", "progamming", new string[] { "Eng,Salah" }, new DateTime(1997,1,7), 125.5M),
            new Book("97451", "Pharmacy", new string[] { "DR,Mohammed" }, new DateTime(2021,7,7), 199.75M)
        };

            #region a
            Console.WriteLine("Using User Defined Delegate.");
            Console.WriteLine("Title :: ");
            LibraryEngine.ProcessBooksUserDefinedDelegate(Books, BookFunctions.GetTitle);
            Console.WriteLine("Price :: ");
            LibraryEngine.ProcessBooksUserDefinedDelegate(Books, BookFunctions.GetPrice);
            #endregion

            #region b
            Console.WriteLine("Using BCL Delegates.");
            Console.WriteLine("Authors :: ");
            LibraryEngine.ProcessBooksBCLDelegates(Books, BookFunctions.GetAuthors);
            #endregion

            #region c
            Console.WriteLine("Using Anonymous Method.");
            Console.WriteLine("ISBN :: ");
            LibraryEngine.ProcessBooksAnonymousMethod(Books);
            #endregion

            #region d
            Console.WriteLine("Using Lambda Expression.");
            Console.WriteLine("Date Time :: ");
            LibraryEngine.ProcessBooksLambdaExpression(Books); 
            #endregion
        }
    }
}
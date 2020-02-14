using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineBook.Entity;

namespace OnlineBook.Respository
{

	public class BookRepositry
	{
		public static List<BookDetail> books = new List<BookDetail>();
		static BookRepositry()
		{
			books.Add(new BookDetail { bookId = 1, bookName = "Harry potter", bookAuthor = "J.K.Rowling" });
			books.Add(new BookDetail { bookId = 2, bookName = "Shakespeare ", bookAuthor = "Romeo Juliet" });
		}
		public static IEnumerable<BookDetail> GetBookDetails()
		{
			return books;
		}
		public void AddBook(BookDetail bookDetail)
		{
			books.Add(bookDetail);
		}
		public BookDetail GetBookById(int bookId)
		{
			return books.Find(id => id.bookId == bookId);
		}
		public void DeleteBook(int packageId)
		{
			BookDetail book = GetBookById(packageId);
			if (book != null)
				books.Remove(book);
		}
		public void UpdateBook(BookDetail book)
		{
			//PackageDetails packages = package.Find(id => id.PackageId == pack.PackageId);
			BookDetail bookDetails = GetBookById(book.bookId);
			bookDetails.bookName = book.bookName;
			bookDetails.bookAuthor = book.bookAuthor;
		}
	}
}

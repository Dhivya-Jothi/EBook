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

	}
}

using System;
using System.Collections.Generic;
using OnlineBook.Entity;

namespace OnlineBook.Respositry
{
	public class BookRepositry
	{
		public static List<BookDetail> books = new List<BookDetail>();
		static BookRepositry()
		{
			books.Add(new BookDetail { bookId = 1, bookName = "Harry potter", bookAuthor = "J.K.Rowling" });
			books.Add(new BookDetail { bookId = 2, bookName = "Harry potter blue moon", bookAuthor = "J.K.Rowling" });
		}
		public static IEnumerable<BookDetail> GetBookDetails()
		{
			return books;
		}
	}
	
	
}

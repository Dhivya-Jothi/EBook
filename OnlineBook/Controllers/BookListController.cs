using OnlineBook.Entity;
using OnlineBook.Respository;
using System;
using System.Collections.Generic;
using System.Web.Mvc;


namespace OnlineBook.Controllers
{
    public class BookListController : Controller
    {
		// GET: BookList
		BookRepositry books;
		public BookListController()
		{
			books = new BookRepositry();
		}
		public ActionResult Index()
        {
			IEnumerable<BookDetail> books = BookRepositry.GetBookDetails();
			return View(books);
		}
	
		[HttpGet]
		public ActionResult Create()
		{
			return View();
		}

		[HttpPost]
		[ActionName("Create")]
		public ActionResult Createbook()
		{
			BookDetail bookDetail = new BookDetail();
			TryUpdateModel(bookDetail);
			books.AddBook(bookDetail);
			TempData["Message"] = "Books added";
			return RedirectToAction("Index");	
		}
		public ActionResult Edit(int id)
		{
			BookRepositry bookRepositry = new BookRepositry();
			BookDetail book = bookRepositry.GetBookById(id);
			return View(book);
		}
		public ActionResult Delete(int id)
		{
			books.DeleteBook(id);
			TempData["Message"] = "Books deleted";
			return RedirectToAction("Index");
		}
		[HttpPost]
		public ActionResult Update(BookDetail book)
		{
			books.UpdateBook(book);
			TempData["Message"] = "Books updated";
			return RedirectToAction("Index");
		}
	}
}
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
			//IEnumerable<BookDetail> books = BookRepositry.GetBookDetails();
			//ViewBag.BookDetails = books;
			//TempData["BookDetails"] = books;
			//ViewData ["BookDetails"] = books;
			//return View();
			IEnumerable<BookDetail> books = BookRepositry.GetBookDetails();
			return View(books);
		}
	
		[HttpGet]
		public ActionResult Create()
		{
			return View();
		}
		[HttpPost]
		public ActionResult Create(BookDetail bookDetail)
		{
			// if(ModelState.IsValid)
			//{
			books.AddBook(bookDetail);
			TempData["Message"] = "Books added";
			return RedirectToAction("Index");
			//}
			//return View(packageDetails);
		}
		public ActionResult Edit(int id)
		{
			BookDetail book = books.GetBookById(id);
			return View(books);
		}
		public ActionResult Delete(int id)
		{
			books.DeleteBook(id);
			TempData["Message"] = "Books deleted";
			return RedirectToAction("Index");
		}
		[HttpPost]
		public ActionResult Update(BookDetail bookDetail)
		{
			// if (ModelState.IsValid)
			//{
			books.UpdateBook(bookDetail);
			TempData["Message"] = "Books updated";
			return RedirectToAction("Index");
			//}
			//return View("Edit",packageDetails);
		}
	}
}
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
        public ActionResult Index()
        {
			IEnumerable<BookDetail> books = BookRepositry.GetBookDetails();
			ViewBag.BookDetails = books;
			TempData["BookDetails"] = books;
			ViewData ["BookDetails"] = books;
			return View();
        }
    }
}
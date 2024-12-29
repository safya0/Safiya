using Library.Models.Entity;
using Library.Repository.IRepo;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class BookController : Controller
    {
        private readonly IBook _Repo;
        public BookController(IBook book)
        {
            _Repo = book;
        }
        public async Task<IActionResult> GetAll()
        {
            return View(await _Repo.GetAllBook());
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Book book)
        {
            await _Repo.Create(book);
            return RedirectToAction("GetAll");
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            return View(await _Repo.Deteils(id));
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Book book)
        {
            await _Repo.Update(book);
            return RedirectToAction("GetAll");
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            return View(await _Repo.Deteils(id));
        }
        [HttpPost]
        public async Task<IActionResult> Delete(Book book)
        {
            await _Repo.Delete(book);
            return RedirectToAction("GetAll");
        }
        public async Task<IActionResult> Details(int id)
        {
            return View(await _Repo.Deteils(id));

        }



    }
}

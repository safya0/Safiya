using Library.Models.Entity;
using Library.Repository;
using Library.Repository.IRepo;
using Library.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class BorrowingController : Controller
    {
        private readonly IBorrowing _Repo;
        private readonly IBook _Repo2;
        private readonly IMember _Repo3;


        public BorrowingController(IBorrowing borrowing, IBook Repo2, IMember Repo3)
        {
            _Repo = borrowing;
            _Repo2 = Repo2;
            _Repo3 = Repo3;

        }

        public async Task<IActionResult> GetAll()
        {
            return View(await _Repo.GetAllBorrowing());
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            BorrowingViewModel borrowingViewModel = new BorrowingViewModel()
            {
                Member = (List<Member>)await _Repo3.GetAllMembers(),
                Book = (List<Book>)await _Repo2.GetAllBook(),
            };
            return View(borrowingViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Create(BorrowingViewModel borrowing)
        {
         await     _Repo.Create(borrowing);
            return RedirectToAction("GetAll");
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id )
        {
            var Brro=await _Repo.Details(id);
            BorrowingViewModel brro = new BorrowingViewModel() { 
            BorrowDate = Brro.BorrowDate,
            ReturnDate = Brro.ReturnDate,
            MemberId=Brro.MemberId,
            Bookid = Brro.Bookid,
                Member = (List<Member>)await _Repo3.GetAllMembers(),
                Book = (List<Book>)await _Repo2.GetAllBook(),
            };
            return View(brro);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, BorrowingViewModel borrowing)
        {
            await _Repo.Update(borrowing,id);
            return RedirectToAction("GetAll");
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
return View(await _Repo.Details(id));
        }
        [HttpPost]
        public async Task<IActionResult> Delete(BorrowingRecord record)
        {
            await _Repo.Delete(record);
            return RedirectToAction("GetAll");
        }





    }
}

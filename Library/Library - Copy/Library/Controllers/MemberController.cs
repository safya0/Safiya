using Library.Models.Entity;
using Library.Repository.IRepo;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class MemberController : Controller
    {
        private readonly IMember _Repo;
        public MemberController(IMember Repo)
        {
            _Repo = Repo;
        }
        public async Task<IActionResult> GetAll()
        {
            return View(await _Repo.GetAllMembers());
        }
        [HttpGet]
        public async Task<IActionResult> Craete()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Craete(Member member)
        {
            await _Repo.Create(member);
            return RedirectToAction("GetAll");
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            return View (await _Repo.Deteils(id));
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Member member)
        {
            await _Repo.Update(member);
            return RedirectToAction("GetAll");
        }
        public async Task<IActionResult> Details(int id)
        {
            return View( await _Repo.Deteils(id));
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            return View( await _Repo.Deteils(id));
        }
        [HttpPost]
        public async Task<IActionResult> Delete(Member member )
        {
         await   _Repo.Delete(member);
            return RedirectToAction("GetAll");
        }

    }
}

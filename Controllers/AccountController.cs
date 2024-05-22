using Microsoft.AspNetCore.Mvc;
using FinalProject.Models;

namespace FinalProject.Controllers
{
    public class AccountController : Controller
    {
        // GET: /Home/Login
        [HttpGet]
        public IActionResult Login()
        {
            return View("~/Views/Home/Login.cshtml");
        }

        // POST: /Home/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Add your login logic here

                return RedirectToAction("Index");
            }

            return View("Login", model);
        }

        // GET: /Home/Register
        [HttpGet]
        public IActionResult Register()
        {
            return View("~/Views/Home/Register.cshtml");
        }

        // POST: /Home/Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Add your registration logic here

                return RedirectToAction("Index");
            }

            return View("Register", model);
        }

        // GET: /Home/Index
        public IActionResult Index()
        {
            return View("~/Views/Home/Index.cshtml");
        }
    }
}

using DAPP.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DAPP.Controllers
{
    public class FormController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult House()
        {
            return View();
        }
        public IActionResult Land()
        {
            return View();
        }
        public IActionResult Price()
        {
            return View();
        }
    }
}

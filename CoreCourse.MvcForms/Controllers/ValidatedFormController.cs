using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreCourse.MvcForms.ViewModels;

namespace CoreCourse.MvcForms.Controllers
{
    public class ValidatedFormController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(ValidatedFormVm userVm)
        {
            if (ModelState.IsValid) 
            {
                return new RedirectToActionResult("CodeSuccess", "ValidatedForm", null);
            }
            else
            {
                return View(userVm);
            }
        }

        public IActionResult CodeSuccess()
        {
            return View();
        }
    }
}

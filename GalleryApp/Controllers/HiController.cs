using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GalleryApp.Controllers
{
    public class HiController : Controller
    {
        //
        // GET: /Hi/
        public IActionResult Index()
        {
            return View();
        }

        //
        // GET: /Hi/Hi
        public string Hi(string name, int times = 1)
        {
            return HtmlEncoder.Default.Encode($"{name} this is hi action method {times} times");
        }

    }
}
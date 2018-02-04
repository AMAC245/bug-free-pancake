using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UsabbbleTest.Controllers
{
    public class GalleryController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var model = new GalleryIndexModel()
            {

            };
            return View(model);
        }
    }
}

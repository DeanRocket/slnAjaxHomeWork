using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjAjaxDemo.Controllers
{
    public class ApiController : Controller
    {
        public IActionResult Index()
        {
            return Content("<h1>Ajax 你好</h1>","text/html",System.Text.Encoding.UTF8);
        }
    }
}

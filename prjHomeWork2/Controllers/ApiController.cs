using Microsoft.AspNetCore.Mvc;
using prjHomeWork2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjHomeWork2.Controllers
{
    public class ApiController : Controller
    {
        private readonly DemoContext _demoContext;
        public ApiController( DemoContext demoContext)
        {
           
            _demoContext = demoContext;
        }

        public IActionResult CheckName(string Name)
        {
            if (string.IsNullOrEmpty(Name))
                return Json("請填入姓名");

            var q = _demoContext.Members.Where(c => c.Name == Name).FirstOrDefault();
            if (q == null)
                return Json("可以使用此名稱");

            return Json("此ID已有人使用");
            
        }
    }
}

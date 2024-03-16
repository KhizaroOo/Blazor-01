using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVC_07.Controllers
{
    public class ToolBoxController : Controller
    {

        #region Listing

        public IActionResult Index()
        {
            return View();
        }

        #endregion

        #region Color Contrast Checker

        public IActionResult Color_Contrast_Checker()
        {
            return View();
        }

        #endregion

    }
}


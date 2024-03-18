using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_07.AppData;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVC_07.Controllers
{
    public class ToolsBoxController : BaseController
    {

        #region Listing

        public IActionResult Index()
        {


            #region ToolBoxes

            List<ToolBox> MyAllToolBoxes = new MyToolBoxes().GetMyToolBoxes(12);

            #endregion

            ViewBag.ME = ME;
            ViewBag.MyAllToolBoxes = MyAllToolBoxes;

            return View();
        }

        #endregion

        #region Color Contrast Checker

        public IActionResult Color_Contrast_Checker()
        {

            ViewBag.ME = ME;

            return View();
        }

        #endregion

    }
}


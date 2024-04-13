﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using MVC_07.AppData;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVC_07.Controllers
{
    public class ArtfulnessController : BaseController
    {

        private readonly IConfiguration _Configuration;
        private readonly ILogger<ArtfulnessController> _logger;

        public ArtfulnessController(ILogger<ArtfulnessController> logger, IConfiguration configuration, IDistributedCache cache) : base(cache, configuration)
        {
            _logger = logger;
            _Configuration = configuration;
        }

        public IActionResult Index()
        {

            #region Arts

            List<Art> MyAllArts = new MyArts().GetMyArts(2000);

            #endregion


            ViewBag.ME = ME;
            ViewBag.MyAllArts = MyAllArts;

            return View();
        }

    }
}

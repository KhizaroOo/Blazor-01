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
    public class WritingsController : BaseController
    {

        private readonly IConfiguration _Configuration;
        private readonly ILogger<WritingsController> _logger;

        public WritingsController(ILogger<WritingsController> logger, IConfiguration configuration, IDistributedCache cache) : base(cache, configuration)
        {
            _logger = logger;
            _Configuration = configuration;
        }

        public IActionResult Index()
        {

            #region Writings

            List<Writing> MyAllWritings = new MyWritings().GetMyWritings(12);

            #endregion


            ViewBag.ME = ME;
            ViewBag.MyAllWritings = MyAllWritings;

            return View();
        }

    }
}


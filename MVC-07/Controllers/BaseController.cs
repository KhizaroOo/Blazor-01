using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using MVC_07.AppData;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVC_07.Controllers
{
    public class BaseController : Controller
    {

        private IDistributedCache cache;
        private readonly IConfiguration _Configuration;


        public BaseController(IDistributedCache cache, IConfiguration configuration)
        {
            this.cache = cache;
            _Configuration = configuration;
        }

        public KhizoOo ME
        {
            get
            {
                return new KhizoOo();
            }
        }


    }
}


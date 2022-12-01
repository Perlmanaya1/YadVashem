using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyYadVashem.Controllers
{

    public class SecondController : AppBaseController
    {
        [HttpGet]
        public string Get()
        {
            return $"{nameof(SecondController)} {nameof(Get)}" + DateTime.Now;
        }
        [HttpGet("Get1")]
        public string Get1()
        {
            return $"{nameof(SecondController)} {nameof(Get1)}" + DateTime.Now;
        }
    }
}

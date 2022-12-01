using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyYadVashem.Controllers
{

    public class FirstController : AppBaseController
    {
        
        [HttpGet]
        public string Get()
        {
            int i = 3;
            return $"{nameof(FirstController)} {nameof(Get)}" + DateTime.Now+(i/0).ToString();
        }
        [HttpGet("Get1")]
        public string Get1()
        {
            return $"{nameof(FirstController)} {nameof(Get1)}" + DateTime.Now;
        }
    }
}

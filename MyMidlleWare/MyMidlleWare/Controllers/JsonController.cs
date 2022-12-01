using Microsoft.AspNetCore.Mvc;
using MyYadVashem.Controllers;
using Newtonsoft.Json;
using System;
using System.Text.Json.Serialization;

namespace MyYadVashem.Controllers
{
    public class JsonController : AppBaseController
    {
        [HttpGet("rightSide")]

        public object Get()
        {
            string allText = System.IO.File.ReadAllText(@"C:\Users\Owner\Desktop\MyMidlleWare\MyMidlleWare\JsonFiles\RightSide.json");

            //object jsonObject = JsonConvert.DeserializeObject(allText);
         //   return jsonObject;
            return allText;
        }


        [HttpGet("leftSide")]
        public string Get2()
        {
            string allText = System.IO.File.ReadAllText(@"C:\Users\Owner\Desktop\MyMidlleWare\MyMidlleWare\JsonFiles\LeftSide.json");

            //object jsonObject = JsonConvert.DeserializeObject(allText);
            // return jsonObject;
            return allText;
        }


    }
}

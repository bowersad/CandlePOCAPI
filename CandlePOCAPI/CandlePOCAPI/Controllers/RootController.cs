using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandlePOCAPI.Controllers
{
    [Route("/")]
    public class RootController : Controller
    {
        public RootController()
        {

        }

        [HttpGet]
        public IActionResult GetRoot()
        {

            return Ok();
        }
    }
}

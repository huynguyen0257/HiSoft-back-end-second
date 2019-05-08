using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HiSoft.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HiSoft.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IProductService _productService;


        public TestController(IProductService productService)
        {
            _productService = productService;
        }

        /// <summary>
        /// Get all if name = null or get room by Name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult GetAll(string name)
        {
            return Ok();
        }
    }
}

using System.Collections;
using Microsoft.AspNetCore.Mvc;

namespace HelloWebapi.Controllers
{
    [ApiController]
    [Route("site")]
    public class SiteController
    {
        [HttpGet]
        [Route("index")]
        public string Index()
        {
            return "hello world";
        }

        [HttpGet]
        [Route("object")]
        public Response Object()
        {
            var response = new Response()
            {
                Code = "1",
                Message = "Ok",
                Result = new ArrayList()
            };

            return response;
        }
    }
}
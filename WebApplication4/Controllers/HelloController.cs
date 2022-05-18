using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;


namespace WebApplication4.Controllers
{


    public class HelloController : ApiController
    {
        [HttpGet]
        public string Index()
        {
            return "Hello World";
        }


        [HttpPost]
        public IHttpActionResult Post(JObject payload)
        {
            return 
        }
        


    }
}
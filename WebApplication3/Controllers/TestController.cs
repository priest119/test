using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication3.Controllers
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class TestController : ApiController
    {
        [HttpPost]
        public string fuck([FromBody]string name) {
            return "老子love"+name;
        }
    }
}

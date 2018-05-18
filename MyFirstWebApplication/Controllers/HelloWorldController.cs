using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstWebApplication.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public string Index(string firstName, string lastName)
        {
            return $"Hello World { firstName} { lastName}!";
        }
    }
}
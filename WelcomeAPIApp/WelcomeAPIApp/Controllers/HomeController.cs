using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WelcomeAPIApp.Controllers
{
    public class HomeController : ApiController
    {
        public IHttpActionResult Get()
        {
            return Json("Get called");
        }

        public IHttpActionResult Post()
        {
            return Json("Post called");
        }
        public IHttpActionResult Delete()
        {
            return Json("Delete called");
        }
        public IHttpActionResult Put()
        {
            return Json("Put called");
        }
    }
}
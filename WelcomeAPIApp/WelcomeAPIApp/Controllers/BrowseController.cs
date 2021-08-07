using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;

namespace WelcomeAPIApp.Controllers 
{
    [RoutePrefix("api/v1/aurionpro")]
    public class BrowseController : ApiController
    {
        [Route("CompanyInformation")]
        public IHttpActionResult Get()
        {
            Random no = new Random();
            int randomNo = no.Next(1, 10);
            if(randomNo > 5)
            {
                return Ok(new { Name = "Aurionpro", Strength = "90", Address = "Thane" });    //returns 200 status code

            }
            if(randomNo == 5)
            {
                HttpStatusCode statusCode = (HttpStatusCode)532;
                return Content(statusCode, "custum status code of 532");
            }
            if(randomNo == 4)
            {
                HttpStatusCode statusCode = (HttpStatusCode)672;
                
                return Content(statusCode, "custum status code of 672");
            }
            
            //return InternalServerError();  //return 500 status code
            //return BadRequest("No company Found");   //returns 400 status code
            return BadRequest("No company Found"); 
        }

        
    }
}
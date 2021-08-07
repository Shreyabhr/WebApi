using Organizations.Models;
using Organizations.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace OrganizationExhibitorWebApiApp.Controllers
{
    [RoutePrefix("api/v1/organizers/{organizerId}/exhibitions")]
    public class ExhibitionsController : ApiController
    {

        private IOrganizationServices _services;

        public ExhibitionsController(IOrganizationServices services)
        {
            _services = services;
        }

        [Route("")]
        public IHttpActionResult Get(Guid organizerId)
        {
            var exhibitors = _services.GetExhibitionsByOrganizerId(organizerId);
            var exhibitorsName =  new List<string>();
            foreach(var exhibit in exhibitors)
            {
                exhibitorsName.Add(exhibit.ExhibitionName);
            }
            if(exhibitors != null)
            {
                return Ok(exhibitorsName);
            }
            return BadRequest("No exhibition availabe for given organizer");
        }

        [Route("{exhibitionId}")]
        public IHttpActionResult Get(Guid organizerId, Guid exhibitionId)
        {
            var exhibitors = _services.GetExhibitionsById(organizerId,exhibitionId);
            if(exhibitors != null)
            {
                return Ok(exhibitors.ExhibitionName);
            }
            return BadRequest("Not found");
            
        }
    }
}
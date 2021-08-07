using Organizations.Models;
using Organizations.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizations.Services
{
    public class OrganizationServices : IOrganizationServices
    {
        private AurionproDBContext _db;

        public OrganizationServices()
        {
            _db = new AurionproDBContext();
        }

        public List<Exhibition> GetExhibitionsByOrganizerId(Guid id)
        {
            var exhibitions = _db.Exhibitions
                              .Where(e => e.Organizer.OrganizerId == id).ToList();

            return exhibitions;


        }

        public Exhibition GetExhibitionsById(Guid organizerId, Guid exhibitionId)
        {
            var exhibitions = _db.Exhibitions
                              .Where(e => (e.ExhibitionId == exhibitionId) && (e.Organizer.OrganizerId == organizerId)).First();
            return exhibitions;
        }
    }
}

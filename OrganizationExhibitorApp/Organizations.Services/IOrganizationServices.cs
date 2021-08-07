using Organizations.Models;
using System;
using System.Collections.Generic;

namespace Organizations.Services
{
    public interface IOrganizationServices
    {
        Exhibition GetExhibitionsById(Guid organizerId, Guid exhibitionId);
        List<Exhibition> GetExhibitionsByOrganizerId(Guid id);
    }
}
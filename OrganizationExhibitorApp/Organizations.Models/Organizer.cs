using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizations.Models
{
    public class Organizer
    {
        [Key]
        public Guid OrganizerId { get; set; }
        public string OrganizerName { get; set; }
        public virtual List<Exhibition> Exhibitors { get; set; }
    }
}

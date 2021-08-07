using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizations.Models
{
    public class Exhibition
    {
        [Key]
        public Guid ExhibitionId { get; set; }
        public string ExhibitionName { get; set; }
        public string Location { get; set; }
        public virtual Organizer Organizer { get; set; }
    }
}

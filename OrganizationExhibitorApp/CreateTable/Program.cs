using Organizations.Models;
using Organizations.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateTable
{
    class Program
    {
        static void Main(string[] args)
        {
            AurionproDBContext db = new AurionproDBContext();

            Organizer o1 = new Organizer { OrganizerId = Guid.NewGuid(), OrganizerName = "blake" };
            Organizer o2 = new Organizer { OrganizerId = Guid.NewGuid(), OrganizerName = "king"};


            Exhibition e1 = new Exhibition { ExhibitionId = Guid.NewGuid(), ExhibitionName = "art", Location = "kalyan", Organizer = o1 };
            Exhibition e2 = new Exhibition { ExhibitionId = Guid.NewGuid(), ExhibitionName = "craft", Location = "mumbai", Organizer = o1 };
            Exhibition e3 = new Exhibition { ExhibitionId = Guid.NewGuid(), ExhibitionName = "painting", Location = "andheri", Organizer = o2 };
            Exhibition e4 = new Exhibition { ExhibitionId = Guid.NewGuid(), ExhibitionName = "book", Location = "parel", Organizer = o2 };

            

            o1.Exhibitors = new List<Exhibition>();
            o1.Exhibitors.Add(e1);
            o1.Exhibitors.Add(e2);
            

            o2.Exhibitors = new List<Exhibition>();
            o2.Exhibitors.Add(e3);
            o2.Exhibitors.Add(e4);

            db.Exhibitions.Add(e1);
            db.Exhibitions.Add(e2);
            db.Exhibitions.Add(e3);
            db.Exhibitions.Add(e4);
            db.Organizers.Add(o1);
            db.Organizers.Add(o2);


            //db.Organizers.Add(o1);
            //db.Organizers.Add(o2);
            db.SaveChanges();

            //db.Exhibitions.Add(e1);
            //db.Exhibitions.Add(e2);
            //db.Exhibitions.Add(e3);
            //db.Exhibitions.Add(e4);
            //db.Organizers.Add(o1);
            //db.Organizers.Add(o2);

            //db.SaveChanges();
        }
    }
}

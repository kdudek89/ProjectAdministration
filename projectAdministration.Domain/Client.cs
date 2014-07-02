using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projectAdministration.Domain
{
    public class Client :IIdentifiable
    {
        public Client()
        {
            Projects = new List<Project>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
        //Each Client can have multiple client feedbacks
        //Each project can have a review with pratices to improve
    }
}

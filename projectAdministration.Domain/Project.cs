using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectAdministration.Domain
{
    public class Project : IIdentifiable
    {
        public Project() {
            Feedbacks = new List<Feedback>();
            Attachments = new List<Attachment>();
            Reviews = new List<Review>();
            this.Users = new HashSet<User>();
 
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ShortName { get; set; }
        //Enum
        public ProjectType projectType { get; set; }
        //Client
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
        //User
        public virtual ICollection<User> Users { get; set; }
        //FeedBack
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        //Attachment
        public virtual ICollection<Attachment> Attachments { get; set; }
        //Reviews
        public virtual ICollection<Review> Reviews { get; set; }
        //Each project has 
        //Each project has a client +
        //Each project can have multiple attachments
        //Each project can have multiple user feedback/notes
        //short name extract from name or Company
        //Source can be the SVN, Git or other details 
    }
}

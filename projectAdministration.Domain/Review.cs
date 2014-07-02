using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projectAdministration.Domain
{
    public class Review : IIdentifiable
    {
        public Review()
        {
            this.Questions = new HashSet<Question>();
        }
        public int Id { get; set; }
        public ReviewType ReviewType { get; set; }
        public string ReviewNotes { get; set; }
        public string ReviewResponse { get; set; }
        public DateTime Date { get; set; }
        //Project ot Review
        public int ProjectId { get; set; }
        public virtual Project Project { get; set; }
        //Question
        public virtual ICollection<Question> Questions { get; set; }
        //Each review can have Questions
        //Review Response is in JSON string 
        //Maybe somthing better than this  ??

        //Review is a process of auditing the project
        //+happiness of the team
        //+improvments
        //+issues with the team/client
        //a way to keep track of the project
        
        //There can also be made a technical review
        //for helping the team with the tasks or improvments
        
    }
}

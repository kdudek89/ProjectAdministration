using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projectAdministration.Domain
{
    public class People : IIdentifiable
    {
        public People()
        {
        }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        public UserStatus UserStatus { get; set; }
        //Each user can have multiple skills or none
        public virtual ICollection<Skill> Skill { get; set; }
        //Each user can have multiple projects or none
        public virtual ICollection<Project> Projects { get; set; }
        //User has access to his accounut and can add skills and                manage them
        //A special account enum or access class
        
    }
}

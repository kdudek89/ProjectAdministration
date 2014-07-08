using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projectAdministration.Domain
{
    public class Skill : IIdentifiable
    {
        public Skill()
        {
            this.Users = new HashSet<People>();
        }
        [Key]
        public int  Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        //skill Category 
        public int SkillCategoryId { get; set; }
        public virtual SkillCategory SkillCategory { get; set; } 
        //Skill to user
        public virtual ICollection<People> Users { get; set; }


        //Skill Characterisitics a sepearate table
        //public int Rating { get; set; }
        //public int Attitude { get; set; }
        //public int Interest { get; set; }
        //public SkillLevel? SkillLevel { get; set; }
    }
}

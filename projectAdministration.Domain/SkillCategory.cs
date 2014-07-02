using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectAdministration.Domain
{
    public class SkillCategory : IIdentifiable
    {
        public SkillCategory()
        {
            Skills = new List<Skill>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public virtual ICollection<Skill> Skills { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projectAdministration.Domain
{
    public class Category : IIdentifiable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool? Deleted { get; set; }
        //The question is should all questions in category be deleted
        //or should the questions be moved to a Main question container
    }
}

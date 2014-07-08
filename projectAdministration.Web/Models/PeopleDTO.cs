using projectAdministration.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projectAdministration.Web.Models
{
    public class PeopleDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public UserStatus UserStatus { get; set; }
    }
}


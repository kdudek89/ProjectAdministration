using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projectAdministration.Domain
{
    public class Attachment :IIdentifiable
    {
    
        public Attachment() { }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Extension { get; set; }
        public byte[] Content { get; set; }
        //One to many Project to Attachment
        public int ProjectId { get; set; }
        public virtual Project Project { get; set; }
    }
}

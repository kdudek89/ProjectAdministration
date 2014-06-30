using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projectAdministration.Domain
{
    public class Feedback
    {
        public Feedback() { }
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Body { get; set; }
        public int Rating { get; set; }
        public DateTime Date { get; set; }
        public int ProjectId { get; set; }
        public virtual Project Project { get; set; }
        //Project
        //Czyli mamy feedback który ma wiadomośc + rating projectu
        //Później można z feedbaców wyciągać średnią


    }
}

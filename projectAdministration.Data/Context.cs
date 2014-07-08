using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projectAdministration.Domain;


namespace projectAdministration.Data
{
     public  class Context : DbContext, IContext 
     {
     static Context()
     {
         Database.SetInitializer<Context>(null);
     }
     public Context(): base("DBConnection") {} 

     public DbSet<Client> Clients { get; set; }
     public DbSet<People> Peoples { get; set; }
     public DbSet<Project> Projects { get; set; }
     public DbSet<Category> Categorys { get; set; }
     public DbSet<Question> Questions { get; set; }
     public DbSet<Feedback> Feedbacks { get; set; }
     public DbSet<Skill> Skills { get; set; }
     public DbSet<Review> Reviews { get; set; }
     public DbSet<SkillCategory> SkillCategorys { get; set; }
     public DbSet<Attachment> Attachments { get; set; }
    
        
    }
}

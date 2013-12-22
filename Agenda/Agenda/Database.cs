using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace DatabaseCreate
{

    public class Users
    {

        public Users()
        {
            Agende = new List<Agenda>();
        }

        [Key]
        public int UserId { get; set; }
        [Required(ErrorMessage = "username is required")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        [Required]
        public virtual ICollection<Agenda> Agende { get; set; }
    }

    public class Agenda
    {
        public Agenda()
        {
          
        }

        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("Users")]
        public int UserId { get; set; }
        [Required]
        public DateTime ora { get; set; }
        [Required]
        public DateTime data { get; set; }
        public string notita { get; set; }

        [Key]
        public int Id { get; set; }

        [Required]
        public virtual Users Users { get; set; }

    }

    public class AgendaDBContext : DbContext
    {

        public AgendaDBContext()
            : base("AgendaDBConnectionString")
        {
            //Database.SetInitializer<AgendaDBContext>(new CreateDatabaseIfNotExists<AgendaDBContext>());
            Database.SetInitializer<AgendaDBContext>(new DropCreateDatabaseIfModelChanges<AgendaDBContext>());
            //Database.SetInitializer<AgendaDBContext>(new DropCreateDatabaseAlways<AgendaDBContext>());
            //Database.SetInitializer<AgendaDBContext>(new SchoolDBInitializer());
        }
        public DbSet<Users> Users { get; set; }
        public DbSet<Agenda> Agenda { get; set; }
    }

}

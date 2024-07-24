using Microsoft.EntityFrameworkCore;

namespace WebApi.Models
{
    public class ContactoContext:DbContext
    {
        public ContactoContext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<Contacto> Contacto { get; set; }

    }
}

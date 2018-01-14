using Microsoft.EntityFrameworkCore;

namespace HolaMundo.Models
{
    public class HolaMundoContext : DbContext
    {
        public HolaMundoContext (DbContextOptions<HolaMundoContext> options) : base(options){

        }
        public DbSet<HolaMundo.Models.Movie> Movie {set; get;}
    }
}
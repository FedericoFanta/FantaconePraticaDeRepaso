using Microsoft.EntityFrameworkCore;
using WSAuto.Models;

namespace WSAuto.Data
{
    public class AutoContext:DbContext
    {
        public AutoContext(DbContextOptions<AutoContext> options) : base(options) { }


        public DbSet<Auto> Autos { get; set; }



    }
     
}

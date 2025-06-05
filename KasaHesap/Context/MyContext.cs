using Microsoft.EntityFrameworkCore;

namespace KasaHesap.Context
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options)
            : base(options) { }
        public DbSet<Models.KasaHesap> KasaHesap { get; set; }
    }
}

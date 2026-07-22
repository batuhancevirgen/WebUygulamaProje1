using Microsoft.EntityFrameworkCore;

namespace WebUygulamaProje1.Utility
{
    public class UygulamaDbContext : DbContext
    {
        public UygulamaDbContext(DbContextOptions<UygulamaDbContext> options) : base(options) 
        {
               
        }

    }
}

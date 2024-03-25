using Microsoft.EntityFrameworkCore;
using nkgPortfolio.Models.Domain;

namespace nkgPortfolio.Data
{
    public class BlogDbContext: DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options): base(options)
        {
        }
        public DbSet<BlogPost> BlogPosts { get; set; }
    }
}

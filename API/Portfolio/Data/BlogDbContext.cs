using Microsoft.EntityFrameworkCore;
using Portfolio.Models.Domain;

namespace Portfolio.Data
{
  public class BlogDbContext: DbContext
  {
    public BlogDbContext(DbContextOptions<BlogDbContext> options): base(options)
    {
    }
    public DbSet<BlogPost> BlogPosts { get; set; }
  }
}

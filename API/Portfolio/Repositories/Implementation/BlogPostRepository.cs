using Portfolio.Data;
using Portfolio.Models.Domain;
using Portfolio.Repositories.Interface;

namespace Portfolio.Repositories.Implementation
{
  public class BlogPostRepository : IBlogPostRepository
  {
    private readonly BlogDbContext dbContext;

    // Inject DbContext into Constructor
    public BlogPostRepository(BlogDbContext dbContext)
    {
      this.dbContext = dbContext;
    }
    public async Task<BlogPost> CreateAsync(BlogPost blogPost)
    {
      await dbContext.BlogPosts.AddAsync(blogPost);
      await dbContext.SaveChangesAsync();

      return blogPost;
    }

    public Task<BlogPost?> DeleteAsync(Guid id)
    {
      throw new NotImplementedException();
    }

    public Task<IEnumerable<BlogPost>> GetAllAsync()
    {
      throw new NotImplementedException();
    }

    public Task<BlogPost?> GetByIdAsync(Guid id)
    {
      throw new NotImplementedException();
    }

    public Task<BlogPost?> GetByUrlHandleAsync(string urlHandle)
    {
      throw new NotImplementedException();
    }

    public Task<BlogPost?> UpdateAsync(BlogPost blogPost)
    {
      throw new NotImplementedException();
    }
  }
}

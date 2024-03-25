using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using nkgPortfolio.Data;
using nkgPortfolio.Models.Domain;
using nkgPortfolio.Models.DTO;
using nkgPortfolio.Repositories.Implementation;

namespace nkgPortfolio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogPostController : ControllerBase
    {
        private readonly BlogPostRepository blogPostRepository;

        public BlogPostController(BlogPostRepository blogPostRepository)
        {
            this.blogPostRepository = blogPostRepository;
        }

        // Create BlogPost
        [HttpPost]
        public async Task<IActionResult> CreateBlogPost([FromBody] CreateBlogPostRequestDto request)
        {
            // Convert Dto to Domain model
            var blogPost = new BlogPost { 
                Title = request.Title, 
                Description = request.Description,
                Content = request.Content,
                UrlHandle = request.UrlHandle,
                FeaturedImage = request.FeaturedImage,
                PublishedDate = request.PublishedDate,
                isVisible = request.isVisible
            };

            // Add BlogPost to DbContext
            blogPost = await blogPostRepository.CreateAsync(blogPost);

            // Convert Domain model to Dto
            var response = new BlogPostDto
            {
                Id = blogPost.Id,
                Title = blogPost.Title,
                Description = blogPost.Description,
                Content = blogPost.Content,
                UrlHandle = blogPost.UrlHandle,
                PublishedDate = blogPost.PublishedDate,
                FeaturedImage = blogPost.FeaturedImage,
                isVisible = blogPost.isVisible
            };

            // Return Domain model
            return Ok(response);
        }

        // Get All BlogPosts
        // Get BlogPost by ID
        // Get BlogPost by URL Handle
        // Update BlogPost
        // Delete BlogPost
    }
}

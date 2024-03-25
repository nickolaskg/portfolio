﻿namespace Portfolio.Models.DTO
{
  public class CreateBlogPostRequestDto
  {
    public DateTime PublishedDate { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Content { get; set; }
    public string UrlHandle { get; set; }
    public string FeaturedImage { get; set; }
    public bool isVisible { get; set; }

  }
}

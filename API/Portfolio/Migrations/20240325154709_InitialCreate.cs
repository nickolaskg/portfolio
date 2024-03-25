using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portfolio.Migrations
{
  /// <inheritdoc />
  public partial class InitialCreate : Migration
  {
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.CreateTable(
        name: "BlogPosts",
        columns: table => new
        {
          Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
          PublishedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
          Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
          Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
          Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
          UrlHandle = table.Column<string>(type: "nvarchar(max)", nullable: false),
          FeaturedImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
          isVisible = table.Column<bool>(type: "bit", nullable: false)
        },
        constraints: table =>
        {
          table.PrimaryKey("PK_BlogPosts", x => x.Id);
        });
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.DropTable(
        name: "BlogPosts");
    }
  }
}

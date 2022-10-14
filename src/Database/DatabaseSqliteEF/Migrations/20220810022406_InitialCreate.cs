using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseSqliteEf.Migrations;

public partial class InitialCreate : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "blog",
            columns: table => new
            {
                BlogId = table.Column<int>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                Url = table.Column<string>(type: "TEXT", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_blog", x => x.BlogId);
            });

        migrationBuilder.CreateTable(
            name: "Posts",
            columns: table => new
            {
                PostId = table.Column<int>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                Title = table.Column<string>(type: "TEXT", nullable: false),
                Content = table.Column<string>(type: "TEXT", nullable: false),
                BlogId = table.Column<int>(type: "INTEGER", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Posts", x => x.PostId);
                table.ForeignKey(
                    name: "FK_Posts_blog_BlogId",
                    column: x => x.BlogId,
                    principalTable: "blog",
                    principalColumn: "BlogId",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateIndex(
            name: "IX_Posts_BlogId",
            table: "Posts",
            column: "BlogId");
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "Posts");

        migrationBuilder.DropTable(
            name: "blog");
    }
}

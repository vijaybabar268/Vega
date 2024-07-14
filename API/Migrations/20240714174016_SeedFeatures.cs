using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class SeedFeatures : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Air Bags')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('ABS Brakes')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('AC')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Auto Climate Control')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Music System')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Sun Roof')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Features");
        }
    }
}

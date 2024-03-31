using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TareasMVC.Migrations
{
    /// <inheritdoc />
    public partial class AdminRol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"IF NOT EXISTS(Select Id From AspNetRoles where id = 'a18d388b-d5f4-496b-a5db-6188cbe81b4f')
                    BEGIN
	                    INSERT AspNetRoles (Id, [Name], [NormalizedName])
	                    VALUES ('a18d388b-d5f4-496b-a5db-6188cbe81b4f','admin', 'ADMIN')
                    END
                    ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE AspNetRoles WHERE Id = 'a18d388b-d5f4-496b-a5db-6188cbe81b4f'");

        }
    }
}

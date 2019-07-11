using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EfCoreSample.Persistance.Migrations
{
    public partial class v9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employee_Project_ProjectsId",
                schema: "efcoresample",
                table: "employee");

            migrationBuilder.DropIndex(
                name: "IX_employee_ProjectsId",
                schema: "efcoresample",
                table: "employee");

            migrationBuilder.DropColumn(
                name: "ProjectsId",
                schema: "efcoresample",
                table: "employee");

            migrationBuilder.CreateTable(
                name: "EmployeeProjects",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EmployeeId = table.Column<long>(nullable: false),
                    ProjectId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeProjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeProjects_employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalSchema: "efcoresample",
                        principalTable: "employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeProjects_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Project",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeProjects_EmployeeId",
                table: "EmployeeProjects",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeProjects_ProjectId",
                table: "EmployeeProjects",
                column: "ProjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeProjects");

            migrationBuilder.AddColumn<long>(
                name: "ProjectsId",
                schema: "efcoresample",
                table: "employee",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_employee_ProjectsId",
                schema: "efcoresample",
                table: "employee",
                column: "ProjectsId");

            migrationBuilder.AddForeignKey(
                name: "FK_employee_Project_ProjectsId",
                schema: "efcoresample",
                table: "employee",
                column: "ProjectsId",
                principalTable: "Project",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

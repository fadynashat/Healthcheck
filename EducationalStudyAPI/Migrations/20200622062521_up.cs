using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EducationalStudyAPI.Migrations
{
    public partial class up : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "completlocalizationschoolstudies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClassesNumber = table.Column<int>(nullable: true),
                    NeedAreaPosition = table.Column<string>(nullable: true),
                    NearestPlacesToBuilding = table.Column<string>(nullable: true),
                    LandPieceCode = table.Column<int>(nullable: true),
                    SurrondSchoolsEffects = table.Column<string>(nullable: true),
                    EducationType = table.Column<string>(nullable: true),
                    PeriodStatus2 = table.Column<string>(nullable: true),
                    ConfirmedStudentNumber = table.Column<int>(nullable: true),
                    StudentType = table.Column<string>(nullable: true),
                    RadiusEmiratizationCircle = table.Column<string>(nullable: true),
                    StudyDate = table.Column<DateTime>(nullable: true),
                    EducationalPhase = table.Column<string>(nullable: true),
                    SchoolsPosition = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_completlocalizationschoolstudies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "queryedustudyinperiods",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SchoolArea = table.Column<int>(nullable: true),
                    BuildingCode = table.Column<int>(nullable: true),
                    BuildingOwnership = table.Column<string>(nullable: true),
                    ClassroomNumber = table.Column<int>(nullable: true),
                    LandPieceCode = table.Column<string>(nullable: true),
                    StudentsNumber = table.Column<int>(nullable: true),
                    PeriodNumber = table.Column<string>(nullable: true),
                    LandOwnership = table.Column<string>(nullable: true),
                    StudyDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_queryedustudyinperiods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "schoolstudiesforauthprojs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LandPieceCode = table.Column<int>(nullable: true),
                    PhaseCode = table.Column<string>(nullable: true),
                    StudentsNumber = table.Column<int>(nullable: true),
                    StudyDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_schoolstudiesforauthprojs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "studentdatainschoolstudies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BuildingCode = table.Column<int>(nullable: true),
                    LandPieceCode = table.Column<int>(nullable: true),
                    StudentsNumber = table.Column<string>(nullable: true),
                    PeriodName = table.Column<string>(nullable: true),
                    PeriodNumber = table.Column<string>(nullable: true),
                    StudyDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_studentdatainschoolstudies", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "completlocalizationschoolstudies");

            migrationBuilder.DropTable(
                name: "queryedustudyinperiods");

            migrationBuilder.DropTable(
                name: "schoolstudiesforauthprojs");

            migrationBuilder.DropTable(
                name: "studentdatainschoolstudies");
        }
    }
}

﻿// <auto-generated />
using System;
using EducationalStudyAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EducationalStudyAPI.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20200622062521_up")]
    partial class up
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EducationalStudyAPI.Models.Completlocalizationschoolstudy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClassesNumber");

                    b.Property<int?>("ConfirmedStudentNumber");

                    b.Property<string>("EducationType");

                    b.Property<string>("EducationalPhase");

                    b.Property<int?>("LandPieceCode");

                    b.Property<string>("NearestPlacesToBuilding");

                    b.Property<string>("NeedAreaPosition");

                    b.Property<string>("PeriodStatus2");

                    b.Property<string>("RadiusEmiratizationCircle");

                    b.Property<string>("SchoolsPosition");

                    b.Property<string>("StudentType");

                    b.Property<DateTime?>("StudyDate");

                    b.Property<string>("SurrondSchoolsEffects");

                    b.HasKey("Id");

                    b.ToTable("completlocalizationschoolstudies");
                });

            modelBuilder.Entity("EducationalStudyAPI.Models.Queryedustudyinperiod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BuildingCode");

                    b.Property<string>("BuildingOwnership");

                    b.Property<int?>("ClassroomNumber");

                    b.Property<string>("LandOwnership");

                    b.Property<string>("LandPieceCode");

                    b.Property<string>("PeriodNumber");

                    b.Property<int?>("SchoolArea");

                    b.Property<int?>("StudentsNumber");

                    b.Property<DateTime?>("StudyDate");

                    b.HasKey("Id");

                    b.ToTable("queryedustudyinperiods");
                });

            modelBuilder.Entity("EducationalStudyAPI.Models.Schoolstudiesforauthproj", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("LandPieceCode");

                    b.Property<string>("PhaseCode");

                    b.Property<int?>("StudentsNumber");

                    b.Property<DateTime?>("StudyDate");

                    b.HasKey("Id");

                    b.ToTable("schoolstudiesforauthprojs");
                });

            modelBuilder.Entity("EducationalStudyAPI.Models.Studentdatainschoolstudy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BuildingCode");

                    b.Property<int?>("LandPieceCode");

                    b.Property<string>("PeriodName");

                    b.Property<string>("PeriodNumber");

                    b.Property<string>("StudentsNumber");

                    b.Property<DateTime?>("StudyDate");

                    b.HasKey("Id");

                    b.ToTable("studentdatainschoolstudies");
                });
#pragma warning restore 612, 618
        }
    }
}
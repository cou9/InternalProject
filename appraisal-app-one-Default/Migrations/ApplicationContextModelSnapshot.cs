﻿// <auto-generated />
using System;
using Apprisal.web.App_mvc_.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Apprisal.web.App_mvc_.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Apprisal.web.App_mvc_.Data.ApprisalEnitity", b =>
                {
                    b.Property<int>("ApprisalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ApprisalId"), 1L, 1);

                    b.Property<string>("AboutCourse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Certifiate")
                        .HasColumnType("int");

                    b.Property<int>("ClientDelivery")
                        .HasColumnType("int");

                    b.Property<string>("ClientDeliveryFeed")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateOfJoin")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("EvoluvationPeriod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Feedback")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("NumberOfLeavesTaken")
                        .HasColumnType("float");

                    b.Property<string>("ResponsibilitiesFeed")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Responsibility")
                        .HasColumnType("int");

                    b.Property<int>("Skills")
                        .HasColumnType("int");

                    b.Property<string>("SkillsFeed")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ApprisalId");

                    b.ToTable("Form");
                });
#pragma warning restore 612, 618
        }
    }
}

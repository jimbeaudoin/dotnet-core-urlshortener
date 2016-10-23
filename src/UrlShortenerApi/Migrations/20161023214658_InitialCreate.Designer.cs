using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using UrlShortenerApi.Data;

namespace UrlShortenerApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20161023214658_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("UrlShortenerApi.Models.Header", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationDate");

                    b.Property<int>("RequestCount");

                    b.Property<string>("RequestIp");

                    b.Property<int>("UrlID");

                    b.Property<string>("UserAgent");

                    b.HasKey("ID");

                    b.HasIndex("UrlID");

                    b.ToTable("Headers");
                });

            modelBuilder.Entity("UrlShortenerApi.Models.Url", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedByIp");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("LongFormat");

                    b.Property<string>("ShortFormat");

                    b.HasKey("ID");

                    b.ToTable("Urls");
                });

            modelBuilder.Entity("UrlShortenerApi.Models.Header", b =>
                {
                    b.HasOne("UrlShortenerApi.Models.Url", "Url")
                        .WithMany("Headers")
                        .HasForeignKey("UrlID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using UrlShortenerApi.Data;

namespace UrlShortenerApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("UrlShortenerApi.Models.Header", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("RequestIp");

                    b.Property<Guid>("UrlId");

                    b.Property<string>("UserAgent");

                    b.HasKey("Id");

                    b.HasIndex("UrlId");

                    b.ToTable("Headers");
                });

            modelBuilder.Entity("UrlShortenerApi.Models.Url", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedByIp");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("LongFormat")
                        .IsRequired();

                    b.Property<string>("ShortFormat");

                    b.HasKey("Id");

                    b.ToTable("Urls");
                });

            modelBuilder.Entity("UrlShortenerApi.Models.Header", b =>
                {
                    b.HasOne("UrlShortenerApi.Models.Url", "Url")
                        .WithMany("Headers")
                        .HasForeignKey("UrlId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}

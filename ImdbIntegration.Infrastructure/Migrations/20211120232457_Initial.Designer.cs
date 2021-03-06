// <auto-generated />
using System;
using ImdbIntegration.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ImdbIntegration.Infrastructure.Migrations
{
    [DbContext(typeof(ImdbContext))]
    [Migration("20211120232457_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ImdbIntegration.Domain.Models.WatchListItem", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("FilmId")
                        .HasColumnType("nvarchar(9)")
                        .HasMaxLength(9);

                    b.Property<bool>("IsWatched")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastOffered")
                        .HasColumnType("datetime2");

                    b.HasKey("UserId", "FilmId");

                    b.ToTable("WatchListItems");
                });
#pragma warning restore 612, 618
        }
    }
}

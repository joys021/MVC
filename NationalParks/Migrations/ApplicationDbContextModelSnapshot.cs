﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NationalParks.DataAccess;

namespace NationalParks.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NationalParks.Models.Accessibility", b =>
                {
                    b.Property<string>("id");

                    b.Property<string>("adainfo");

                    b.Property<string>("additionalinfo");

                    b.Property<string>("cellphoneinfo");

                    b.Property<string>("firestovepolicy");

                    b.Property<string>("internetinfo");

                    b.Property<string>("rvallowed");

                    b.Property<string>("rvinfo");

                    b.Property<string>("rvmaxlength");

                    b.Property<string>("trailerallowed");

                    b.Property<string>("trailermaxlength");

                    b.Property<string>("wheelchairaccess");

                    b.HasKey("id");

                    b.ToTable("Accessibilityy");
                });

            modelBuilder.Entity("NationalParks.Models.Campsites", b =>
                {
                    b.Property<string>("id");

                    b.Property<string>("electricalhookups");

                    b.Property<string>("group");

                    b.Property<string>("horse");

                    b.Property<string>("other");

                    b.Property<string>("rvonly");

                    b.Property<string>("tentonly");

                    b.Property<string>("totalsites");

                    b.Property<string>("walkboatto");

                    b.HasKey("id");

                    b.ToTable("Campsite");
                });

            modelBuilder.Entity("NationalParks.Models.Datum", b =>
                {
                    b.Property<string>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("description");

                    b.Property<string>("directionsUrl");

                    b.Property<string>("directionsoverview");

                    b.Property<string>("latLong");

                    b.Property<string>("name");

                    b.Property<string>("parkCode");

                    b.Property<string>("regulationsoverview");

                    b.Property<string>("regulationsurl");

                    b.Property<string>("reservationsdescription");

                    b.Property<string>("reservationssitesfirstcome");

                    b.Property<string>("reservationssitesreservable");

                    b.Property<string>("reservationsurl");

                    b.Property<string>("weatheroverview");

                    b.HasKey("id");

                    b.ToTable("RootObject");
                });

            modelBuilder.Entity("NationalParks.Models.Park", b =>
                {
                    b.Property<string>("parkCode")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("description");

                    b.Property<string>("designation");

                    b.Property<string>("directionsInfo");

                    b.Property<string>("directionsUrl");

                    b.Property<string>("fullName");

                    b.Property<string>("id");

                    b.Property<string>("latLong");

                    b.Property<string>("name");

                    b.Property<string>("states");

                    b.Property<string>("url");

                    b.Property<string>("weatherInfo");

                    b.HasKey("parkCode");

                    b.ToTable("Parks");
                });

            modelBuilder.Entity("NationalParks.Models.Accessibility", b =>
                {
                    b.HasOne("NationalParks.Models.Datum", "Datum")
                        .WithOne("accessibility")
                        .HasForeignKey("NationalParks.Models.Accessibility", "id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NationalParks.Models.Campsites", b =>
                {
                    b.HasOne("NationalParks.Models.Datum", "Datum")
                        .WithOne("campsites")
                        .HasForeignKey("NationalParks.Models.Campsites", "id")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

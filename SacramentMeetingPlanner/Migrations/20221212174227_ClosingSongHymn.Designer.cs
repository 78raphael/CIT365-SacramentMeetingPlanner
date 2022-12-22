﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SacramentMeetingPlanner.Data;

#nullable disable

namespace SacramentMeetingPlanner.Migrations
{
    [DbContext(typeof(SacramentMeetingContext))]
    [Migration("20221212174227_ClosingSongHymn")]
    partial class ClosingSongHymn
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SacramentMeetingPlanner.Models.Meeting", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Benediction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClosingSong")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClosingSongHymn")
                        .HasColumnType("int");

                    b.Property<string>("Conducting")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IntermediateMusicalNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IntermediateMusicalNumberHymn")
                        .HasColumnType("int");

                    b.Property<string>("Invocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("MeetingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("OpeningSong")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OpeningSongHymn")
                        .HasColumnType("int");

                    b.Property<string>("SacramentHymn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SacramentHymnChoice")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Meeting", (string)null);
                });

            modelBuilder.Entity("SacramentMeetingPlanner.Models.Speaker", b =>
                {
                    b.Property<int>("SpeakerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SpeakerId"), 1L, 1);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MeetingId")
                        .HasColumnType("int");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SpeakerId");

                    b.HasIndex("MeetingId");

                    b.ToTable("Speaker", (string)null);
                });

            modelBuilder.Entity("SacramentMeetingPlanner.Models.Speaker", b =>
                {
                    b.HasOne("SacramentMeetingPlanner.Models.Meeting", null)
                        .WithMany("Speakers")
                        .HasForeignKey("MeetingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SacramentMeetingPlanner.Models.Meeting", b =>
                {
                    b.Navigation("Speakers");
                });
#pragma warning restore 612, 618
        }
    }
}

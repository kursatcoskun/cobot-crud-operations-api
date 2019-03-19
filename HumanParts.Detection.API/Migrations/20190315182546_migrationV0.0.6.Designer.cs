﻿// <auto-generated />
using System;
using HumanParts.Detection.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HumanParts.Detection.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20190315182546_migrationV0.0.6")]
    partial class migrationV006
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HumanParts.Detection.API.Models.DetectedObject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("DetectedObjects");
                });

            modelBuilder.Entity("HumanParts.Detection.API.Models.DetectionModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("detectedObjectId");

                    b.Property<DateTime>("detectionTime");

                    b.Property<int>("deviceId");

                    b.HasKey("Id");

                    b.HasIndex("detectedObjectId");

                    b.HasIndex("deviceId");

                    b.ToTable("Detections");
                });

            modelBuilder.Entity("HumanParts.Detection.API.Models.Device", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<string>("OperatingSystemVersion");

                    b.Property<string>("rosVersion");

                    b.HasKey("Id");

                    b.ToTable("Devices");
                });

            modelBuilder.Entity("HumanParts.Detection.API.Models.DetectionModel", b =>
                {
                    b.HasOne("HumanParts.Detection.API.Models.DetectedObject", "detectedObject")
                        .WithMany()
                        .HasForeignKey("detectedObjectId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HumanParts.Detection.API.Models.Device", "device")
                        .WithMany()
                        .HasForeignKey("deviceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
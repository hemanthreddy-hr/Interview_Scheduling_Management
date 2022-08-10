﻿// <auto-generated />
using System;
using InterviewSchedulingProject1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InterviewSchedulingProject1.Migrations
{
    [DbContext(typeof(ISPContext))]
    [Migration("20220716041906_initials7")]
    partial class initials7
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("InterviewSchedulingProject1.Models.CandidateUser", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<DateTime?>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Gender")
                        .HasColumnType("int");

                    b.Property<DateTime?>("InterviewTiming")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("firstname")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("lastname")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("phoneno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("selected")
                        .HasColumnType("bit");

                    b.Property<string>("username")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id");

                    b.ToTable("CandidateUser");
                });

            modelBuilder.Entity("InterviewSchedulingProject1.Models.CondidateDetails", b =>
                {
                    b.Property<int>("canditateid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("canditateid"), 1L, 1);

                    b.Property<int?>("Candidateid")
                        .HasColumnType("int");

                    b.Property<string>("Company")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<float?>("Experince")
                        .HasColumnType("real");

                    b.Property<float?>("graduation")
                        .HasColumnType("real");

                    b.Property<float?>("postgraduation")
                        .HasColumnType("real");

                    b.Property<string>("skills")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<float?>("tenth")
                        .HasColumnType("real");

                    b.Property<float?>("twelth")
                        .HasColumnType("real");

                    b.HasKey("canditateid");

                    b.HasIndex("Candidateid");

                    b.ToTable("condidateDetails");
                });

            modelBuilder.Entity("InterviewSchedulingProject1.Models.getcondidatedetailselected", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("Company")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<float?>("Experince")
                        .HasColumnType("real");

                    b.Property<int?>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float?>("graduation")
                        .HasColumnType("real");

                    b.Property<string>("lastname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phoneno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float?>("postgraduation")
                        .HasColumnType("real");

                    b.Property<bool?>("selected")
                        .HasColumnType("bit");

                    b.Property<string>("skills")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float?>("tenth")
                        .HasColumnType("real");

                    b.Property<float?>("twelth")
                        .HasColumnType("real");

                    b.Property<string>("username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("candidateFullDetails");
                });

            modelBuilder.Entity("InterviewSchedulingProject1.Models.CondidateDetails", b =>
                {
                    b.HasOne("InterviewSchedulingProject1.Models.CandidateUser", "id")
                        .WithMany()
                        .HasForeignKey("Candidateid");

                    b.Navigation("id");
                });
#pragma warning restore 612, 618
        }
    }
}

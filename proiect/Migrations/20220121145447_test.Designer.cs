﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using proiect.Data;
using proiect.Models;

namespace proiect.Migrations
{
    [DbContext(typeof(ProiectContext))]
    [Migration("20220121145447_test")]
    partial class test
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("proiect.Models.DataBaseModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DataBaseModels");
                });

            modelBuilder.Entity("proiect.Models.Relations.ManyToMany.Model3", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Models3");
                });

            modelBuilder.Entity("proiect.Models.Relations.ManyToMany.Model4", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Models4");
                });

            modelBuilder.Entity("proiect.Models.Relations.ManyToMany.ModelsRelation", b =>
                {
                    b.Property<Guid>("Model3Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Model4Id")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Model3Id", "Model4Id");

                    b.HasIndex("Model4Id");

                    b.ToTable("ModelsRelations");
                });

            modelBuilder.Entity("proiect.Models.Relations.OneToMany.Model1", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Models1");
                });

            modelBuilder.Entity("proiect.Models.Relations.OneToMany.Model2", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Model1Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Model1Id");

                    b.ToTable("Models2");
                });

            modelBuilder.Entity("proiect.Models.Relations.OneToOne.Model5", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Model6Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Models5");
                });

            modelBuilder.Entity("proiect.Models.Relations.OneToOne.Model6", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Model5Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Model5Id")
                        .IsUnique();

                    b.ToTable("Models6");
                });

            modelBuilder.Entity("proiect.Models.Relations.ManyToMany.ModelsRelation", b =>
                {
                    b.HasOne("proiect.Models.Relations.ManyToMany.Model3", "Model3")
                        .WithMany("ModelRelations")
                        .HasForeignKey("Model3Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("proiect.Models.Relations.ManyToMany.Model4", "Model4")
                        .WithMany("ModelRelations")
                        .HasForeignKey("Model4Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Model3");

                    b.Navigation("Model4");
                });

            modelBuilder.Entity("proiect.Models.Relations.OneToMany.Model2", b =>
                {
                    b.HasOne("proiect.Models.Relations.OneToMany.Model1", "Model1")
                        .WithMany("Models2")
                        .HasForeignKey("Model1Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Model1");
                });

            modelBuilder.Entity("proiect.Models.Relations.OneToOne.Model6", b =>
                {
                    b.HasOne("proiect.Models.Relations.OneToOne.Model5", "Model5")
                        .WithOne("Model6")
                        .HasForeignKey("proiect.Models.Relations.OneToOne.Model6", "Model5Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Model5");
                });

            modelBuilder.Entity("proiect.Models.Relations.ManyToMany.Model3", b =>
                {
                    b.Navigation("ModelRelations");
                });

            modelBuilder.Entity("proiect.Models.Relations.ManyToMany.Model4", b =>
                {
                    b.Navigation("ModelRelations");
                });

            modelBuilder.Entity("proiect.Models.Relations.OneToMany.Model1", b =>
                {
                    b.Navigation("Models2");
                });

            modelBuilder.Entity("proiect.Models.Relations.OneToOne.Model5", b =>
                {
                    b.Navigation("Model6");
                });
#pragma warning restore 612, 618
        }
    }
}

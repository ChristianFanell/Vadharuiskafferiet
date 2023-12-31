﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Vadharuiskafferiet.Persistence;

#nullable disable

namespace Vadharuiskafferiet.Persistence.Migrations
{
    [DbContext(typeof(RecepieDbContext))]
    partial class RecepieDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Vadharuiskafferiet.Domain.Aggregates.Recepie.Entities.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedTimeStamp")
                        .HasColumnType("datetime2");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IngredientType")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedTimeStamp")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("Vadharuiskafferiet.Domain.Aggregates.Recepie.Entities.Recepie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedTimeStamp")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedTimeStamp")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Recepies");
                });

            modelBuilder.Entity("Vadharuiskafferiet.Persistence.Entities.RecepieIngredientJoinTable", b =>
                {
                    b.Property<int>("IngredientId")
                        .HasColumnType("int");

                    b.Property<int>("RecepieId")
                        .HasColumnType("int");

                    b.HasKey("IngredientId", "RecepieId");

                    b.HasIndex("RecepieId");

                    b.ToTable("RecepieIngredientJoinTable");
                });

            modelBuilder.Entity("Vadharuiskafferiet.Domain.Aggregates.Recepie.Entities.Ingredient", b =>
                {
                    b.OwnsOne("Vadharuiskafferiet.Domain.Aggregates.ValueObjects.NameValueObject", "Name", b1 =>
                        {
                            b1.Property<int>("IngredientId")
                                .HasColumnType("int");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("Name");

                            b1.HasKey("IngredientId");

                            b1.ToTable("Ingredients");

                            b1.WithOwner()
                                .HasForeignKey("IngredientId");
                        });

                    b.Navigation("Name")
                        .IsRequired();
                });

            modelBuilder.Entity("Vadharuiskafferiet.Domain.Aggregates.Recepie.Entities.Recepie", b =>
                {
                    b.OwnsOne("Vadharuiskafferiet.Domain.Aggregates.ValueObjects.NameValueObject", "RecepieName", b1 =>
                        {
                            b1.Property<int>("RecepieId")
                                .HasColumnType("int");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("Name");

                            b1.HasKey("RecepieId");

                            b1.ToTable("Recepies");

                            b1.WithOwner()
                                .HasForeignKey("RecepieId");
                        });

                    b.OwnsOne("Vadharuiskafferiet.Domain.Aggregates.ValueObjects.DescriptionValueObject", "Description", b1 =>
                        {
                            b1.Property<int>("RecepieId")
                                .HasColumnType("int");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("Description");

                            b1.HasKey("RecepieId");

                            b1.ToTable("Recepies");

                            b1.WithOwner()
                                .HasForeignKey("RecepieId");
                        });

                    b.OwnsOne("Vadharuiskafferiet.Domain.Aggregates.ValueObjects.RecepieStepValueObject", "Steps", b1 =>
                        {
                            b1.Property<int>("RecepieId")
                                .HasColumnType("int");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("Steps");

                            b1.HasKey("RecepieId");

                            b1.ToTable("Recepies");

                            b1.WithOwner()
                                .HasForeignKey("RecepieId");
                        });

                    b.Navigation("Description")
                        .IsRequired();

                    b.Navigation("RecepieName")
                        .IsRequired();

                    b.Navigation("Steps")
                        .IsRequired();
                });

            modelBuilder.Entity("Vadharuiskafferiet.Persistence.Entities.RecepieIngredientJoinTable", b =>
                {
                    b.HasOne("Vadharuiskafferiet.Domain.Aggregates.Recepie.Entities.Ingredient", null)
                        .WithMany()
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Vadharuiskafferiet.Domain.Aggregates.Recepie.Entities.Recepie", null)
                        .WithMany()
                        .HasForeignKey("RecepieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

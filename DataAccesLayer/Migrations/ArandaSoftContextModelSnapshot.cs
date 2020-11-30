﻿// <auto-generated />
using System;
using DataAccesLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccesLayer.Migrations
{
    [DbContext(typeof(ArandaSoftContext))]
    partial class ArandaSoftContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Entities.Acciones", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Acciones");
                });

            modelBuilder.Entity("Entities.RolAcciones", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AccionesId")
                        .HasColumnType("int");

                    b.Property<int>("RolesRolId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccionesId");

                    b.HasIndex("RolesRolId");

                    b.ToTable("RolAcciones");
                });

            modelBuilder.Entity("Entities.Roles", b =>
                {
                    b.Property<int>("RolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Estado")
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RolId");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            RolId = 1,
                            Estado = "A",
                            FechaCreacion = new DateTime(2020, 11, 29, 21, 42, 5, 205, DateTimeKind.Local).AddTicks(1228),
                            Nombre = "Visitante"
                        },
                        new
                        {
                            RolId = 2,
                            Estado = "A",
                            FechaCreacion = new DateTime(2020, 11, 29, 21, 42, 5, 206, DateTimeKind.Local).AddTicks(4913),
                            Nombre = "Asistente"
                        },
                        new
                        {
                            RolId = 3,
                            Estado = "A",
                            FechaCreacion = new DateTime(2020, 11, 29, 21, 42, 5, 206, DateTimeKind.Local).AddTicks(4960),
                            Nombre = "Editor"
                        },
                        new
                        {
                            RolId = 4,
                            Estado = "A",
                            FechaCreacion = new DateTime(2020, 11, 29, 21, 42, 5, 206, DateTimeKind.Local).AddTicks(4964),
                            Nombre = "Administrador"
                        });
                });

            modelBuilder.Entity("Entities.Usuarios", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RolesRolId")
                        .HasColumnType("int");

                    b.Property<string>("Telefono")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Usuario")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("RolesRolId");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Apellidos = "Forero",
                            Direccion = "Calle 120 # 45 -67",
                            Edad = 20,
                            Email = "tania.forero@arandasoft.com",
                            Estado = "A",
                            FechaCreacion = new DateTime(2020, 11, 29, 21, 42, 5, 215, DateTimeKind.Local).AddTicks(8103),
                            FechaNacimiento = new DateTime(2000, 11, 29, 21, 42, 5, 215, DateTimeKind.Local).AddTicks(4375),
                            Nombres = "Tania Lized",
                            Password = "a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3",
                            RolesRolId = 4,
                            Telefono = "7563000",
                            Usuario = "admon"
                        });
                });

            modelBuilder.Entity("Entities.RolAcciones", b =>
                {
                    b.HasOne("Entities.Acciones", "Accione")
                        .WithMany("RolaAcciones")
                        .HasForeignKey("AccionesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Roles", "Roles")
                        .WithMany("RolaAcciones")
                        .HasForeignKey("RolesRolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Accione");

                    b.Navigation("Roles");
                });

            modelBuilder.Entity("Entities.Usuarios", b =>
                {
                    b.HasOne("Entities.Roles", "Roles")
                        .WithMany("Usuarios")
                        .HasForeignKey("RolesRolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Roles");
                });

            modelBuilder.Entity("Entities.Acciones", b =>
                {
                    b.Navigation("RolaAcciones");
                });

            modelBuilder.Entity("Entities.Roles", b =>
                {
                    b.Navigation("RolaAcciones");

                    b.Navigation("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}

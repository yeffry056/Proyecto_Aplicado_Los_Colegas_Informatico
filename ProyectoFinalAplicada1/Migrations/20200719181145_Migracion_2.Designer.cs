﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProyectoFinalAplicada1.DAL;

namespace ProyectoFinalAplicada1.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20200719181145_Migracion_2")]
    partial class Migracion_2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6");

            modelBuilder.Entity("ProyectoFinalAplicada1.Entidades.UsuarioDetalle", b =>
                {
                    b.Property<int>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Apellido")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.HasKey("UsuarioId");

                    b.ToTable("UsuarioDetalle");
                });

            modelBuilder.Entity("ProyectoFinalAplicada1.Entidades.Usuarios", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Apellidos")
                        .HasColumnType("TEXT");

                    b.Property<string>("Contrasena")
                        .HasColumnType("TEXT");

                    b.Property<string>("NombreUsuario")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombres")
                        .HasColumnType("TEXT");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            UsuarioId = 1,
                            Apellidos = "Fermin.",
                            Contrasena = "5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5",
                            NombreUsuario = "COD1",
                            Nombres = "Eladio."
                        });
                });

            modelBuilder.Entity("ProyectoFinalAplicada1.Entidades.UsuarioDetalle", b =>
                {
                    b.HasOne("ProyectoFinalAplicada1.Entidades.Usuarios", null)
                        .WithMany("Detalle")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

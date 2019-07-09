﻿// <auto-generated />
using System;
using ClinicaVeterinaria.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ClinicaVeterinaria.Migrations
{
    [DbContext(typeof(ClinicaVeterinariaContext))]
    [Migration("20190702215130_Mig5")]
    partial class Mig5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ClinicaVeterinaria.Models.Agenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataConsulta");

                    b.Property<int>("PetId");

                    b.Property<int>("VeterinarioId");

                    b.HasKey("Id");

                    b.HasIndex("PetId");

                    b.HasIndex("VeterinarioId");

                    b.ToTable("Agenda");
                });

            modelBuilder.Entity("ClinicaVeterinaria.Models.Consulta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Data_Consulta");

                    b.Property<string>("Descricao");

                    b.Property<string>("Motivo");

                    b.Property<int>("PetId");

                    b.Property<string>("Receita");

                    b.Property<int>("VeterinarioId");

                    b.HasKey("Id");

                    b.HasIndex("PetId");

                    b.HasIndex("VeterinarioId");

                    b.ToTable("Consulta");
                });

            modelBuilder.Entity("ClinicaVeterinaria.Models.Pet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Idade");

                    b.Property<string>("Nome");

                    b.Property<int>("Peso");

                    b.Property<int>("ProprietarioId");

                    b.Property<string>("Raca");

                    b.HasKey("Id");

                    b.HasIndex("ProprietarioId");

                    b.ToTable("Pet");
                });

            modelBuilder.Entity("ClinicaVeterinaria.Models.Proprietario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("Endereco");

                    b.Property<string>("Nome");

                    b.Property<string>("Rg");

                    b.Property<string>("Telefone");

                    b.HasKey("Id");

                    b.ToTable("Proprietario");
                });

            modelBuilder.Entity("ClinicaVeterinaria.Models.Veterinario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CRMV");

                    b.Property<string>("Email");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Veterinario");
                });

            modelBuilder.Entity("ClinicaVeterinaria.Models.Agenda", b =>
                {
                    b.HasOne("ClinicaVeterinaria.Models.Pet", "Pet")
                        .WithMany("Agenda")
                        .HasForeignKey("PetId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ClinicaVeterinaria.Models.Veterinario", "Veterinario")
                        .WithMany("Agenda")
                        .HasForeignKey("VeterinarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ClinicaVeterinaria.Models.Consulta", b =>
                {
                    b.HasOne("ClinicaVeterinaria.Models.Pet", "Pet")
                        .WithMany("Consulta")
                        .HasForeignKey("PetId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ClinicaVeterinaria.Models.Veterinario", "Veterinario")
                        .WithMany("Consulta")
                        .HasForeignKey("VeterinarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ClinicaVeterinaria.Models.Pet", b =>
                {
                    b.HasOne("ClinicaVeterinaria.Models.Proprietario", "Proprietario")
                        .WithMany("Pet")
                        .HasForeignKey("ProprietarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

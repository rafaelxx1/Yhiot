﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Yhiot.API.Data;

#nullable disable

namespace Yhiot.API.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("Yhiot.API.Models.Agendamento", b =>
                {
                    b.Property<int>("AgendamentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DataAgendamento")
                        .HasColumnType("TEXT");

                    b.Property<string>("ExameName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Medico")
                        .HasColumnType("TEXT");

                    b.Property<string>("cpf")
                        .HasColumnType("TEXT");

                    b.Property<string>("foto")
                        .HasColumnType("TEXT");

                    b.HasKey("AgendamentoId");

                    b.ToTable("agendamentos");
                });

            modelBuilder.Entity("Yhiot.API.Models.User", b =>
                {
                    b.Property<int>("userId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("data")
                        .HasColumnType("TEXT");

                    b.Property<string>("userAut")
                        .HasColumnType("TEXT");

                    b.Property<string>("userCpf")
                        .HasColumnType("TEXT");

                    b.Property<string>("userEmail")
                        .HasColumnType("TEXT");

                    b.Property<string>("userInterface")
                        .HasColumnType("TEXT");

                    b.Property<string>("userName")
                        .HasColumnType("TEXT");

                    b.Property<string>("userPassword")
                        .HasColumnType("TEXT");

                    b.HasKey("userId");

                    b.ToTable("users");
                });
#pragma warning restore 612, 618
        }
    }
}

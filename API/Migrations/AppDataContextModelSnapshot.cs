﻿// <auto-generated />
using API.Properties;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Migrations
{
    [DbContext(typeof(AppDataContext))]
    partial class AppDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("API.models.Aluno", b =>
                {
                    b.Property<string>("AlunoId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("SobreNome")
                        .HasColumnType("TEXT");

                    b.HasKey("AlunoId");

                    b.ToTable("Aluno");
                });

            modelBuilder.Entity("API.models.Imc", b =>
                {
                    b.Property<string>("ImcId")
                        .HasColumnType("TEXT");

                    b.Property<int>("Altura")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quilos")
                        .HasColumnType("INTEGER");

                    b.HasKey("ImcId");

                    b.ToTable("Imc");
                });
#pragma warning restore 612, 618
        }
    }
}
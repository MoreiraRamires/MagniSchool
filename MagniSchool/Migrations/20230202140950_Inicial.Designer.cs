﻿// <auto-generated />
using System;
using MagniSchool.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MagniSchool.Migrations
{
    [DbContext(typeof(BancoContext))]
    [Migration("20230202140950_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CursoDisciplina", b =>
                {
                    b.Property<int>("CursosId")
                        .HasColumnType("int");

                    b.Property<int>("DisciplinasId")
                        .HasColumnType("int");

                    b.HasKey("CursosId", "DisciplinasId");

                    b.HasIndex("DisciplinasId");

                    b.ToTable("CursoDisciplina");
                });

            modelBuilder.Entity("MagniSchool.Models.Aluno", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("CursoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DisciplinaId")
                        .HasColumnType("int");

                    b.Property<int>("Matricula")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Notas")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("CursoId");

                    b.HasIndex("DisciplinaId");

                    b.ToTable("Aluno");
                });

            modelBuilder.Entity("MagniSchool.Models.Curso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("MediaNotas")
                        .HasColumnType("real");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProfessorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Cursos");
                });

            modelBuilder.Entity("MagniSchool.Models.Disciplina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("MediaNota")
                        .HasColumnType("real");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProfessorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Disciplinas");
                });

            modelBuilder.Entity("MagniSchool.Models.Professor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Salario")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Professores");
                });

            modelBuilder.Entity("CursoDisciplina", b =>
                {
                    b.HasOne("MagniSchool.Models.Curso", null)
                        .WithMany()
                        .HasForeignKey("CursosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MagniSchool.Models.Disciplina", null)
                        .WithMany()
                        .HasForeignKey("DisciplinasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MagniSchool.Models.Aluno", b =>
                {
                    b.HasOne("MagniSchool.Models.Curso", null)
                        .WithMany("Alunos")
                        .HasForeignKey("CursoId");

                    b.HasOne("MagniSchool.Models.Disciplina", null)
                        .WithMany("Alunos")
                        .HasForeignKey("DisciplinaId");
                });

            modelBuilder.Entity("MagniSchool.Models.Curso", b =>
                {
                    b.HasOne("MagniSchool.Models.Professor", "Professor")
                        .WithMany()
                        .HasForeignKey("ProfessorId");

                    b.Navigation("Professor");
                });

            modelBuilder.Entity("MagniSchool.Models.Disciplina", b =>
                {
                    b.HasOne("MagniSchool.Models.Professor", "Professor")
                        .WithMany()
                        .HasForeignKey("ProfessorId");

                    b.Navigation("Professor");
                });

            modelBuilder.Entity("MagniSchool.Models.Curso", b =>
                {
                    b.Navigation("Alunos");
                });

            modelBuilder.Entity("MagniSchool.Models.Disciplina", b =>
                {
                    b.Navigation("Alunos");
                });
#pragma warning restore 612, 618
        }
    }
}
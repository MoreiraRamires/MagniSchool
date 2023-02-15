using MagniSchool.Models;
using Microsoft.EntityFrameworkCore;

namespace MagniSchool.Data
{
    public class BancoContext :DbContext 
    {
      
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {

        }

        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Professor> Professores { get; set; }

        public DbSet<Disciplina> Disciplinas { get; set; }

        public DbSet<Aluno> Alunos { get; set; }

    }

}

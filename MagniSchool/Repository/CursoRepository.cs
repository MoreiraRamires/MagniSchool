using MagniSchool.Data;
using MagniSchool.Models;
using MagniSchool.Repository.Interface;
using System.Collections.Generic;
using System.Linq;

namespace MagniSchool.Repository
{
    public class CursoRepository : ICursoRepository
    {
        private readonly BancoContext _bancoContext;
        public CursoRepository(BancoContext bancoContext)
        {
            _bancoContext= bancoContext;
        }

        public Curso Adicionar(Curso curso)
        {
            _bancoContext.Cursos.Add(curso);
            _bancoContext.SaveChanges();
            return curso;
        }

        public Curso Atualizar(Curso curso)
        {
            Curso cursoDb = BuscarCursoPorId(curso.Id);

            cursoDb.Nome = curso.Nome;

            _bancoContext.Cursos.Update(cursoDb);
            _bancoContext.SaveChanges();
            return curso;
        }

        public Curso BuscarCursoPorId(int id)
        {
            Curso curso = _bancoContext.Cursos.Find(id);
            return curso;
        }

        public List<Curso> BuscarTodos()
        {
            List<Curso> cursos = _bancoContext.Cursos.ToList();
            return cursos;
        }
    }


}

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

        public bool Deletar(int id)
        {
            Curso cursoDb = BuscarCursoPorId(id);

            if (cursoDb == null) throw new System.Exception("Não foi possível deletar esse curso");
            _bancoContext.Cursos.Remove(cursoDb);
            _bancoContext.SaveChanges();
            return true;
        }
    }


}

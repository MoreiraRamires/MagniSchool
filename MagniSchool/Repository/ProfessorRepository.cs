using MagniSchool.Data;
using MagniSchool.Models;
using MagniSchool.Repository.Interface;
using System.Collections.Generic;
using System.Linq;

namespace MagniSchool.Repository
{
    public class ProfessorRepository : IProfessorRepository
    {
        private readonly BancoContext _bancoContext;

        public ProfessorRepository(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public Professor Adicionar(Professor professor)
        {
            _bancoContext.Professores.Add(professor);
            _bancoContext.SaveChanges();
            return professor;
        }
        public Professor Atualizar(Professor professor)
        {

            Professor professorDb = BuscarProfessorPorId(professor.Id);


            professorDb.Nome = professor.Nome;
            professorDb.DataNascimento = professor.DataNascimento;
            professorDb.Salario = professor.Salario;

            _bancoContext.Professores.Update(professorDb);
            _bancoContext.SaveChanges();
            return professor;
        }


        public Professor BuscarProfessorPorId(int id)
        {
          Professor professor =  _bancoContext.Professores.Find(id);
          return professor;
        }

        public List<Professor> BuscarTodos()
        {
            return _bancoContext.Professores.ToList();
        }

        public bool Deletar(int id)
        {
            Professor professorDb = BuscarProfessorPorId(id);

            if (professorDb == null) throw new System.Exception("Não foi possível deletar esse professor");

            _bancoContext.Professores.Remove(professorDb);
            _bancoContext.SaveChanges();

            return true;
        }
    }
}

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

        public List<Professor> BuscarTodos()
        {
            return _bancoContext.Professores.ToList();
        }
    }
}

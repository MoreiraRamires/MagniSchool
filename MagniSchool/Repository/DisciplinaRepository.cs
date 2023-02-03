using MagniSchool.Data;
using MagniSchool.Models;
using MagniSchool.Repository.Interface;
using System.Collections.Generic;
using System.Linq;

namespace MagniSchool.Repository
{
    public class DisciplinaRepository : IDisciplinaRepository
    {
        private readonly BancoContext _bancoContext;
        public DisciplinaRepository(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public Disciplina Adicionar(Disciplina disciplina)
        {
            _bancoContext.Disciplinas.Add(disciplina);
            _bancoContext.SaveChanges();
            return disciplina;
        }

        public List<Disciplina> BuscarTodos()
        {
            List<Disciplina> disciplinas= _bancoContext.Disciplinas.ToList();
            return disciplinas;
        }
    }
}

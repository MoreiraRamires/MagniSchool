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

        public Disciplina AtualizarDados(Disciplina disciplina)
        {
            Disciplina disciplinaDB = BuscarPorId(disciplina.Id);

            disciplinaDB.Nome = disciplina.Nome;
            disciplinaDB.Professor = disciplina.Professor;

            _bancoContext.Disciplinas.Update(disciplinaDB);
            _bancoContext.SaveChanges();

            return disciplina;
        }

        public Disciplina BuscarPorId(int id)
        {
            Disciplina disciplina = _bancoContext.Disciplinas.SingleOrDefault(x => x.Id == id);
            return disciplina;
        }

        public List<Disciplina> BuscarTodos()
        {
            List<Disciplina> disciplinas= _bancoContext.Disciplinas.ToList();
            return disciplinas;
        }
    }
}

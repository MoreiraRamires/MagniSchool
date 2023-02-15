using MagniSchool.Data;
using MagniSchool.Models;
using MagniSchool.Repository.Interface;
using System.Collections.Generic;

namespace MagniSchool.Repository
{
    public class AlunoRepository : IAlunoRepository
    {
        private readonly BancoContext _bancoContext;
        public AlunoRepository(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }


        public Aluno Adicionar(Aluno aluno)
        {
            _bancoContext.Alunos.Add(aluno);
            _bancoContext.SaveChanges();
            return aluno;
        }

        public Aluno Atualizar(Aluno curso)
        {
            throw new System.NotImplementedException();
        }

        public Aluno BuscarAlunoPorId(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Aluno> BuscarTodos()
        {
            throw new System.NotImplementedException();
        }

        public bool Deletar(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}

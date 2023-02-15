using MagniSchool.Models;
using System.Collections.Generic;

namespace MagniSchool.Repository.Interface
{
    public interface IAlunoRepository
    {
        List<Aluno> BuscarTodos();
        Aluno BuscarAlunoPorId(int id);
        Aluno Adicionar(Aluno aluno);

        Aluno Atualizar(Aluno curso);

        bool Deletar(int id);
    }
}

using MagniSchool.Models;
using System.Collections.Generic;

namespace MagniSchool.Repository.Interface
{
    public interface IDisciplinaRepository
    {
        Disciplina Adicionar(Disciplina disciplina);
        Disciplina AtualizarDados(Disciplina disciplina);
        Disciplina BuscarPorId(int id);
        List<Disciplina> BuscarTodos();
        bool Deletar(int id);
    }
}

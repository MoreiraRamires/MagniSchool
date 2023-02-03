using MagniSchool.Models;
using System.Collections.Generic;

namespace MagniSchool.Repository.Interface
{
    public interface IDisciplinaRepository
    {
        Disciplina Adicionar(Disciplina disciplina);

        List<Disciplina> BuscarTodos();
    }
}

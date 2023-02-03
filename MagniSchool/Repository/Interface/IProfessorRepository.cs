using MagniSchool.Models;
using System.Collections.Generic;

namespace MagniSchool.Repository.Interface
{
    public interface IProfessorRepository
    {
        Professor Adicionar (Professor professor);

        List<Professor> BuscarTodos();

    }
}

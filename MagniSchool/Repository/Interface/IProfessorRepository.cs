using MagniSchool.Models;
using System.Collections.Generic;

namespace MagniSchool.Repository.Interface
{
    public interface IProfessorRepository
    {
        Professor Adicionar (Professor professor);

        public Professor Atualizar(Professor professor);
        Professor BuscarProfessorPorId(int id);
        List<Professor> BuscarTodos();

    }
}

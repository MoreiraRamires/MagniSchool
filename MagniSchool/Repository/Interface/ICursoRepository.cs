using MagniSchool.Models;
using System.Collections.Generic;

namespace MagniSchool.Repository.Interface
{
    public interface ICursoRepository
    {
        List<Curso> BuscarTodos();
        Curso BuscarCursoPorId(int id);
        Curso Adicionar(Curso curso);

        Curso Atualizar(Curso curso);
    }
}

using System;
using System.Collections.Generic;

namespace MagniSchool.Models
{
    public class Aluno
    {
        public Aluno()
        {

        }

        public Guid Id { get; set; }
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        
        List<Disciplina> DisciplinasMatriculado { get; set; }


        public float Notas { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace MagniSchool.Models
{
    public class Disciplina
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Professor Professor { get; set; }
        public  List<Curso> Cursos { get; set; }

        public List<Aluno> Alunos { get; set; }
    
        public float MediaNota { get; set; }
    }

}

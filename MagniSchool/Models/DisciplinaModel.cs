using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MagniSchool.Models
{
    public class Disciplina
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Informe o Nome da Disciplina")]
        public string Nome { get; set; }

        //[Required(ErrorMessage = "Informe o Nome do Professor")]
        public Professor Professor { get; set; }
        public  List<Curso> Cursos { get; set; }

        public List<Aluno> Alunos { get; set; }
    
        public float MediaNota { get; set; }
    }

}

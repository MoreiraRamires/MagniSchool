using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MagniSchool.Models
{
    public class Aluno
    {
        public Aluno()
        {

        }

        public Guid Id { get; set; }
        
        [StringLength(10, MinimumLength = 4)]
        [Required(ErrorMessage = "Matricula inválida.")]
        public int Matricula { get; set; }
        
        
        [Required(ErrorMessage = "Informe o nome do Aluno")]
        public string Nome { get; set; }


        [DisplayFormat(DataFormatString = "mm/dd/yyyy")] 
        public DateTime DataNascimento { get; set; }
        
        List<Disciplina> DisciplinasMatriculado { get; set; }


        public float Notas { get; set; }
    }
}

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MagniSchool.Models
{
    public class Curso
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o Nome do Curso")] 
        public string Nome { get; set; }

        public Professor Professor { get; set; }
        public List<Disciplina> Disciplinas { get; set; }
        public List<Aluno> Alunos { get; set; }
        public float MediaNotas { get; set; }
    }
}

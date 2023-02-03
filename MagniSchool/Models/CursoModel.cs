using System.Collections.Generic;

namespace MagniSchool.Models
{
    public class Curso
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public Professor Professor { get; set; }
        public List<Disciplina> Disciplinas { get; set; }
        public List<Aluno> Alunos { get; set; }
        public float MediaNotas { get; set; }
    }
}

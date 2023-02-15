using System;
using System.ComponentModel.DataAnnotations;

namespace MagniSchool.Models
{
    public class Professor
    {
    public int Id { get; set; }



    [Required(ErrorMessage = "Informe o Nome do Professor")]
    public string Nome { get; set; }
    public DateTime DataNascimento { get; set; }

    public float Salario { get; set; }
    }

}

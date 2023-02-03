using MagniSchool.Models;
using MagniSchool.Repository.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MagniSchool.Controllers
{
    public class ProfessorController : Controller
    {
        private readonly IProfessorRepository _professorRepository;
        public ProfessorController(IProfessorRepository professorRepository)
        {
            _professorRepository= professorRepository;
        }
        public IActionResult Index()
        {
            List<Professor> professores = _professorRepository.BuscarTodos();
            return View(professores);
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(Professor professor)
        {
            _professorRepository.Adicionar(professor);
            return RedirectToAction("Index");
        }
    }
}

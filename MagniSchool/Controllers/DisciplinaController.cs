using MagniSchool.Models;
using MagniSchool.Repository;
using MagniSchool.Repository.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MagniSchool.Controllers
{
    public class DisciplinaController : Controller
    {
        private readonly IDisciplinaRepository _disciplinaRepository;
        public DisciplinaController(IDisciplinaRepository disciplinaRepository)
        {
            _disciplinaRepository= disciplinaRepository;
        }
        public IActionResult Index()
        {
            List<Disciplina> disciplinas = _disciplinaRepository.BuscarTodos();

            return View(disciplinas);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Disciplina disciplina)
        {
            _disciplinaRepository.Adicionar(disciplina);
            return RedirectToAction("Index");
        }
    }
}

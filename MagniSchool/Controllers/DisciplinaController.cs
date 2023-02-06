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
        public IActionResult Edit(int id)
        {
            Disciplina disciplina = _disciplinaRepository.BuscarPorId(id);

            return View(disciplina);
        }

        [HttpPost]
        public IActionResult Create(Disciplina disciplina)
        {
            _disciplinaRepository.Adicionar(disciplina);
            return RedirectToAction("Index");
        }

        public IActionResult Alterar(Disciplina disciplina)
        {
            _disciplinaRepository.AtualizarDados(disciplina);
            

            return RedirectToAction("Index");

        }
    }
}

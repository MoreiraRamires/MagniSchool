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

        public IActionResult Delete(int id)
        {
            Professor professor = _professorRepository.BuscarProfessorPorId(id);
            return View(professor);
        }

        

        public IActionResult Edit(int id)
        {
            Professor professor = _professorRepository.BuscarProfessorPorId(id);
            return View(professor);
        }


        [HttpPost]
        public IActionResult Create(Professor professor)
        {

            if(ModelState.IsValid)
            {
                _professorRepository.Adicionar(professor);
                return RedirectToAction("Index");

            }
            return View(professor);
        }

        [HttpPost]
        public IActionResult Edit(Professor professor)
        {
            if (ModelState.IsValid)
            {
                _professorRepository.Atualizar(professor); 
                return RedirectToAction("Index");
            }
            return View(professor);
        }

        public IActionResult Deletar(int id)
        {
            _professorRepository.Deletar(id);

            return RedirectToAction("Index");
        }
    }
}

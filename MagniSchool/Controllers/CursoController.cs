using MagniSchool.Models;

using MagniSchool.Repository.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MagniSchool.Controllers
{
    public class CursoController : Controller
    {
        private readonly ICursoRepository _cursoRepository;
        public CursoController(ICursoRepository cursoRepository)
        {
            _cursoRepository= cursoRepository;
        }
        public IActionResult Index()
        {
            List<Curso> cursos= _cursoRepository.BuscarTodos();
            return View(cursos);
        }
        public IActionResult Edit(int id)
        {
            Curso curso = _cursoRepository.BuscarCursoPorId(id);
            return View(curso);

        }

        public IActionResult Delete(int id)
        {
            Curso curso = _cursoRepository.BuscarCursoPorId(id);
            return View(curso);
        }

        public IActionResult DeleteAll(int id)
        {
            _cursoRepository.Deletar(id);
            return RedirectToAction("Index");
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create( Curso curso)
        {
            if(ModelState.IsValid)
            {
                _cursoRepository.Adicionar(curso);
                return RedirectToAction("Index");
            }

            return View(curso);


        }

        [HttpPost]
        public IActionResult Alterar(Curso curso)
        {
            if (ModelState.IsValid)
            {
                _cursoRepository.Atualizar(curso);

                return RedirectToAction("Index");

            }

            return View("Edit",curso);
        }
    }
}

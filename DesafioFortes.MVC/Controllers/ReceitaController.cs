using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using DesafioFortes.Application.Interface;
using DesafioFortes.Domain.Entities;
using DesafioFortes.MVC.ViewModels;

namespace DesafioFortes.MVC.Controllers
{
    public class ReceitaController : Controller
    {
        private readonly IReceitaAppService _receitaApp;
        private readonly ICategoriaAppService _categoriaApp;

        public ReceitaController(IReceitaAppService receitaApp, ICategoriaAppService categoriaApp)
        {
            _receitaApp = receitaApp;
            _categoriaApp = categoriaApp;
        }

        //
        // GET: /Receitas/
        public ActionResult Index()
        {
            ViewBag.Categorias = new SelectList(_categoriaApp.GetAll(), "CategoriaId", "Nome");
            var receitaViewModel = Mapper.Map<IEnumerable<Receita>, IEnumerable<ReceitaViewModel>>(_receitaApp.GetAll());
            return View(receitaViewModel);
        }

        [HttpPost]
        public ViewResult Index(int? id)
        {
            ViewBag.Categorias = new SelectList(_categoriaApp.GetAll(), "CategoriaId", "Nome");
            var receitaViewModel = Mapper.Map<IEnumerable<Receita>, IEnumerable<ReceitaViewModel>>(id != null ? _categoriaApp.FiltrarReceitasPorCategoria(id) : _receitaApp.GetAll());
            return View(receitaViewModel);
        }

        //
        // GET: /Receitas/Details/5
        public ActionResult Details(int id)
        {
            var receita = _receitaApp.GetById(id);
            var receitaViewModel = Mapper.Map<Receita, ReceitaViewModel>(receita);
            return View(receitaViewModel);
        }

        //
        // GET: /Receitas/Create
        public ActionResult Create()
        {
            ViewBag.Categorias = new SelectList(_categoriaApp.GetAll(), "CategoriaId", "Nome");
            return View();
        }

        //
        // POST: /Receitas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ReceitaViewModel receita)
        {
            if (ModelState.IsValid)
            {
                var receitaDomain = Mapper.Map<ReceitaViewModel, Receita>(receita);
                _receitaApp.Add(receitaDomain);
                return RedirectToAction("Index");
            }

            ViewBag.Categorias = new SelectList(_categoriaApp.GetAll(), "CategoriaId", "Nome", receita.CategoriaId);
            return View(receita);
        }

        //
        // GET: /Receitas/Edit/5
        public ActionResult Edit(int id)
        {
            var receita = _receitaApp.GetById(id);
            var receitaViewModel = Mapper.Map<Receita, ReceitaViewModel>(receita);
            ViewBag.Categorias = new SelectList(_categoriaApp.GetAll(), "CategoriaId", "Nome", receitaViewModel.CategoriaId);
            return View(receitaViewModel);
        }

        //
        // POST: /Receitas/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ReceitaViewModel receita)
        {
            if (ModelState.IsValid)
            {
                var receitaDomain = Mapper.Map<ReceitaViewModel, Receita>(receita);
                _receitaApp.Update(receitaDomain);
                return RedirectToAction("Index");
            }
            ViewBag.Categorias = new SelectList(_categoriaApp.GetAll(), "CategoriaId", "Nome", receita.CategoriaId);
            return View(receita);
        }

        //
        // GET: /Receitas/Delete/5
        public ActionResult Delete(int id)
        {
            var receita = _receitaApp.GetById(id);
            var receitaViewModel = Mapper.Map<Receita, ReceitaViewModel>(receita);
            return View(receitaViewModel);
        }

        //
        // POST: /Receitas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var receita = _receitaApp.GetById(id);
            _receitaApp.Remove(receita);
            return RedirectToAction("Index");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using DesafioFortes.Application.Interface;
using DesafioFortes.Domain.Entities;
using DesafioFortes.MVC.ViewModels;

namespace DesafioFortes.MVC.Controllers
{
    public class DespesaController : Controller
    {
        private readonly IDespesaAppService _despesaApp;
        private readonly ICategoriaAppService _categoriaApp;

        public DespesaController(IDespesaAppService despesaApp, ICategoriaAppService categoriaApp)
        {
            _despesaApp = despesaApp;
            _categoriaApp = categoriaApp;
        }
        //
        // GET: /Despesa/
        public ActionResult Index()
        {
            ViewBag.Categorias = new SelectList(_categoriaApp.GetAll(), "CategoriaId", "Nome");
            var despesaViewModel = Mapper.Map<IEnumerable<Despesa>, IEnumerable<DespesaViewModel>>(_despesaApp.GetAll());
            return View(despesaViewModel);
        }

        [HttpPost]
        public ViewResult Index(int? id)
        {
            ViewBag.Categorias = new SelectList(_categoriaApp.GetAll(), "CategoriaId", "Nome");
            var despesaViewModel = Mapper.Map<IEnumerable<Despesa>, IEnumerable<DespesaViewModel>>(id != null ? _categoriaApp.FiltrarDespesasPorCategoria(id) : _despesaApp.GetAll());
            return View(despesaViewModel);
        }


        //
        // GET: /Despesa/Details/5
        public ActionResult Details(int id)
        {
            var despesa = _despesaApp.GetById(id);
            var despesaViewModel = Mapper.Map<Despesa, DespesaViewModel>(despesa);
            return View(despesaViewModel);
        }

        //
        // GET: /Despesa/Create
        public ActionResult Create()
        {
            ViewBag.Categorias = new SelectList(_categoriaApp.GetAll(), "CategoriaId", "Nome");
            return View();
        }

        //
        // POST: /Despesa/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DespesaViewModel despesa)
        {
            if (ModelState.IsValid)
            {
                var despesaDomain = Mapper.Map<DespesaViewModel, Despesa>(despesa);
                _despesaApp.Add(despesaDomain);
                return RedirectToAction("Index");
            }

            ViewBag.Categorias = new SelectList(_categoriaApp.GetAll(), "CategoriaId", "Nome", despesa.CategoriaId);
            return View(despesa);
        }

        //
        // GET: /Despesa/Edit/5
        public ActionResult Edit(int id)
        {
            var despesa = _despesaApp.GetById(id);
            var despesaViewModel = Mapper.Map<Despesa, DespesaViewModel>(despesa);
            ViewBag.Categorias = new SelectList(_categoriaApp.GetAll(), "CategoriaId", "Nome", despesaViewModel.CategoriaId);
            return View(despesaViewModel);
        }

        //
        // POST: /Despesa/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(DespesaViewModel despesa)
        {
            if (ModelState.IsValid)
            {
                var despesaDomain = Mapper.Map<DespesaViewModel, Despesa>(despesa);
                _despesaApp.Update(despesaDomain);
                return RedirectToAction("Index");
            }
            ViewBag.Categorias = new SelectList(_categoriaApp.GetAll(), "CategoriaId", "Nome", despesa.CategoriaId);
            return View(despesa);
        }

        //
        // GET: /Despesa/Delete/5
        public ActionResult Delete(int id)
        {
            var despesa = _despesaApp.GetById(id);
            var despesaViewModel = Mapper.Map<Despesa, DespesaViewModel>(despesa);
            return View(despesaViewModel);
        }

        //
        // POST: /Despesa/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var despesa = _despesaApp.GetById(id);
            _despesaApp.Remove(despesa);
            return RedirectToAction("Index");
        }
    }
}

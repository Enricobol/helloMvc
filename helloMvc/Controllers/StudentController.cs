using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SchoolModel.Entities;
using SchoolModel.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace helloMvc.Controllers
{
    public class StudentController : Controller
    {
        #region Prop
        private readonly ILogger<StudentController> _logger;
        private readonly IDidactisService didacticsService;
        #endregion

        public StudentController(ILogger<StudentController> logger, IDidactisService didacticsService)
        {
            this._logger = logger;
            this.didacticsService = didacticsService;
        }

        #region COMANDI LISTA E DETTAGLI
        //GET: la pagina prende dei dati da usare/mostrare
        public IActionResult Index()
        {
            var students = didacticsService.GetAllStudents().ToList();
            return View(students);
        }

        //GET: la pagina prende dei dati da usare/mostrare
        public IActionResult List(string lastnameLike)
        {
            var students = didacticsService.GetStudentsByLastnameLike(lastnameLike);
            return View(students);
        }

        //GET: la pagina prende dei dati da usare/mostrare
        public IActionResult Details(long id)
        {
            var student = didacticsService.GetStudentById(id);
            return View(student);
        }
        #endregion

        #region COMANDO CREA STUDENTE
        //GET: la pagina prende dei dati da usare/mostrare 
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]//POST: la pagina ritorna dei dati da mettere nel DB
        public IActionResult Create(Student s)
        {
            if (ModelState.IsValid)
            {
                didacticsService.CreateStudent(s);
                return RedirectToAction("Index");
            }
            return View(s);
        }
        #endregion

        #region COMANDO ELIMINA STUDENTE
        //GET: la pagina prende dei dati da usare/mostrare
        public IActionResult Delete(long id, string modificoSoloLaFirma)
        {
            var student = didacticsService.GetStudentById(id);
            return View(student);
        }

        [HttpPost]//POST: la pagina ritorna dei dati da mettere nel DB
        public IActionResult Delete(long id)
        {
            if (ModelState.IsValid)
            {
                didacticsService.DeleteStudentById(id);
                return RedirectToAction("Index");
            }
            return View(id);
        }
        #endregion

        #region COMANDO AGGIORNA STUDENTE
        //GET: la pagina prende dei dati da usare/mostrare
        public IActionResult Edit(long id, string modificoSoloLaFirma)
        {
            var student = didacticsService.GetStudentById(id);
            return View(student);
        }

        [HttpPost]//POST: la pagina ritorna dei dati da mettere nel DB
        public IActionResult Edit([Bind()] Student s) //Nb: Devo usare Bind per utilizzare i dati Editati in Student s
        {
            if (ModelState.IsValid)
            {
                didacticsService.UpdateStudent(s);
                return RedirectToAction("Index");
            }
            return View(s);
        }
        #endregion
    }
}

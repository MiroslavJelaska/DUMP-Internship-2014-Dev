using System;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Dump.Internship.NoteShare.Models;
using Dump.Internship.NoteShare.Services;

namespace Dump.Internship.NoteShare.Controllers
{
    public class NotesController : Controller
    {
        private readonly JsonStorageService<Note> storageService;

        public NotesController()
        {
            this.storageService = new JsonStorageService<Note>();
        }

        public ViewResult List()
        {
            var notesList = this.storageService.ReadAll();
            return View(notesList);
        }

        public ViewResult Details(int id)
        {
            var note = this.storageService.ReadAll().SingleOrDefault(n => n.Id == id);

            if (note == null)
            {
                throw new HttpException((int)HttpStatusCode.NotFound, "Note doesn't exist");
            }

            return View(note);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Note note)
        {
            if (!ModelState.IsValid)
            {
                return View(note);
            }

            note.CreatedOn = DateTime.Now;
            note.Id = GetNextId();

            this.storageService.AddItem(note);

            return RedirectToRoute("Home");
        }

        private int GetNextId()
        {
            var allNotes = this.storageService.ReadAll();

            var lastId = allNotes.Any()
                ? allNotes.Max(n => n.Id)
                : 0;

            return lastId + 1;
        }
    }
}

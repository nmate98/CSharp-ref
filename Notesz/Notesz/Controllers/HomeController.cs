using Notesz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLibrary.Logic;

namespace Notesz.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult osszesJegyzet()
        {
            var data = Proccesser.LoadNote();
            List <NoteModel> notes = new List<NoteModel>();

            foreach(var sor in data)
            {
                notes.Add(new NoteModel { cim = sor.cim, tartalom = sor.tartalom });
            }

            return View(notes);

        }
        
        public ActionResult ujJegyzet()
        {

            return View();

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ujJegyzet(NoteModel model)
        {

            if (ModelState.IsValid)
            {
                int letrehozva = Proccesser.createNote(model.cim, model.tartalom);
                return RedirectToAction("osszesJegyzet");
            }

            return View();

        }

    }
}
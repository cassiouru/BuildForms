using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuildForms.Models;
using BuildForms.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BuildForms.Controllers
{
    public class FormController : Controller
    {
        private readonly BuildFormDbContext _db;

        public FormController(BuildFormDbContext db)
        {
            this._db = db;
        }

        [HttpPost("form/create")]
        public IActionResult Create(FormAnswer model)
        {
            model.Form = this._db.Form.Find(model.FormId);

            for (int i = 0; i < model.Answers.Count; i++)
                model.Answers[i].Answer = HttpContext.Request.Form[$"model.Answers[{i}].Answer"];

            this._db.Add(model);
            this._db.SaveChanges();

            return RedirectToPage("/index");
        }
    }
}
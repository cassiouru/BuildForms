using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuildForms.Models;
using BuildForms.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BuildForms.Pages
{
    public class CreateModel : PageModel
    {
        private readonly BuildFormDbContext _db;

        public CreateModel(BuildFormDbContext db)
        {
            this._db = db;
        }

        [BindProperty]
        public Form Form { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }


            this._db.Add(Form);
            this._db.SaveChanges();

            return RedirectToPage("./index");
        }
    }
}
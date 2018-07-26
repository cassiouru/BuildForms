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
    public class IndexModel : PageModel
    {
        private readonly BuildFormDbContext _db;

        public IndexModel(BuildFormDbContext db)
        {
            this._db = db;
        }

        [BindProperty()]
        public IList<Form> Forms { get; set; }

        public void OnGet()
        {
            this.Forms = _db.Form.ToList();
        }       
    }
}
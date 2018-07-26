using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuildForms.Models;
using BuildForms.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BuildForms.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly BuildFormDbContext _db;

        public DetailsModel(BuildFormDbContext db)
        {
            this._db = db;
        }

        [BindProperty]
        public Form Form { get; set; }

        public void OnGet(int? id)
        {
            this.Form = this._db.Form.Include(x=> x.FormItens).ThenInclude(opt=> opt.Options)
                .SingleOrDefault(x=> x.Id.Equals(id));
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using BuildForms.Models;
using BuildForms.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BuildForms.Pages
{
    public class AnswerModel : PageModel
    {
        private readonly BuildFormDbContext _db;

        public AnswerModel(BuildFormDbContext db)
        {
            this._db = db;
        }

        [BindProperty]
        public IList<FormAnswer> Answers { get; set; } = new List<FormAnswer>();

        public void OnGet(int formId)
        {
            this.Answers = this._db.FormAnswer
                .Include(x=> x.Form)
                .Where(x => x.FormId.Equals(formId)).ToList();
        }
    }
}
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
    public class AnswerDetailModel : PageModel
    {
        private readonly BuildFormDbContext _db;

        public AnswerDetailModel(BuildFormDbContext db)
        {
            this._db = db;
        }

        public IList<FormItemAnswer> FormItemAnswer { get; set; } = new List<FormItemAnswer>();

        public void OnGet(int id)
        {
            this.FormItemAnswer = this._db.FormItemAnswer
                .Include(x => x.FormItem)
                .ThenInclude(x=> x.Options)
                .Where(x => x.FormAnswer.Id.Equals(id))
                .ToList();
        }
    }
}
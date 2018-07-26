using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildForms.Models
{
    public class FormItemAnswer
    {
        public int Id { get; set; }

        public string Question { get; set; }

        public string Answer { get; set; }

        public int FormAnswerId { get; set; }

        public FormAnswer FormAnswer { get; set; }

        public int FormItemId { get; set; }

        public FormItem FormItem { get; set; }
    }
}

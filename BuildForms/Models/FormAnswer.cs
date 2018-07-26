using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildForms.Models
{
    public class FormAnswer
    {
        public int Id { get; set; }

        public int FormId { get; set; }

        public virtual Form Form { get; set; }

        public virtual IList<FormItemAnswer> Answers { get; set; }
    }
}

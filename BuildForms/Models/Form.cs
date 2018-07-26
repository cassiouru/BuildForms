using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildForms.Models
{
    public class Form 
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Action { get; set; }

        public Method Method { get; set; }

        public virtual IList<FormItem> FormItens { get; set; } = new List<FormItem>();
    }

    public enum Method
    {
        Get,
        Post,
        Put,
        Delete
    }
}

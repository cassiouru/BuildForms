using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildForms.Models
{
    public class FormItem
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public string Name { get; set; }

        public Type Type { get; set; }

        public string Placeholder { get; set; }

        public bool Required { get; set; }

        public virtual IList<Option> Options { get; set; } = new List<Option>();

        public int FormId { get; set; }

        public virtual Form Form { get; set; }

        public FormItem()
        {
            this.Name = "Answers";
        }
    }

    public enum Type
    {
        Text,
        Radio,
        Checkbox,
        Select,
        Textarea
    }

    public class Option
    {
        public int Id { get; set; }

        public string Key { get; set; }

        public string Value { get; set; }
    }
}

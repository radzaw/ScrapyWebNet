using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrapyWebNet.Models
{
    public class Project
    {
        public string Name { get; set; }

        public Project(string name)
        {
            this.Name = name;
        }
    }
}

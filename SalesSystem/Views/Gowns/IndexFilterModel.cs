using Microsoft.AspNetCore.Mvc.Rendering;
using SalesSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Views.Gowns
{
    public class IndexFilterModel
    {
        public string orNumber { get; set; }
        public IEnumerable<Gown> gowns { get; set; }
        public string status { get; set; }
        public SelectList statusOptions { get; set; }
        public Gown gown { get; set; }
    }
}

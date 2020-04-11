using System;
using System.Collections.Generic;

namespace covid19.Models
{
    public partial class Provincias
    {
        public int Id { get; set; }
        public string Provincia { get; set; }
        public int? Respiradores { get; set; }
    }
}

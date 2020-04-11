using System;
using System.Collections.Generic;

namespace covid19.Models
{
    public partial class Casos
    {
        public int Id { get; set; }
        public int Provincia_Id { get; set; }
        public int Activos { get; set; }
        public int? Recuperados { get; set; }
        public int? Muertes { get; set; }
    }
}

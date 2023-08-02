using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1.Model
{
    public class DictionaryType
    {

        public Guid Id { get; set; }
        public string Type { get; set; }
        public string? Diameter { get; set; }
        public string? Thickness { get; set; }

        public АluminumAlloy АluminumAlloy { get; set; }
    }
}

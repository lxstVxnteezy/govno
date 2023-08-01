using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public class ChemicalComposition
    {
        [Key]
        public Guid ChemicalComposition_Id { get; set; }

        public string ChemicalComposition_Name { get; set; }
        
        public List<АluminumAlloy> AluminiumAlloys { get; set; } = new();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test1.Entities;

namespace Test1.Model
{
    public class ChemicalComposition
    {
        public Guid АluminumAlloyId { get; set; }
        public АluminumAlloy? АluminumAlloy { get; set; }
        
        public Guid ChemicalElementId { get; set; }
        public ChemicalElement? ChemicalElement { get; set; }
        
        
        public Guid? UnitId { get; set; }
        public Unit? Unit { get; set; }
       
        
        

        public string? NameOfElement { get; set; }

        public string? AmountElement { get; set; }
        public string? UnitName { get; set; }

    }
}

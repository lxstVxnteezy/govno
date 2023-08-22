using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1.Model
{
    public class ChemicalElement
    {
        public Guid Id { get; set; }
        public string? NameOfElement { get; set; }

        public List<АluminumAlloy> АluminumAlloys { get; set; } = new();
        public List<ChemicalComposition> ChemicalCompositions { get; set; } = new();
    }
}

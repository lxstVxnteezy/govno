using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1.Model
{
    public class АluminumAlloy
    {
        public Guid DictionaryTypeId { get; set; }
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public DictionaryType DictType { get; set; }
        public List<ChemicalElement> ChemicalElements { get; set; } = new();
        public List<ChemicalComposition> ChemicalCompositions { get; set; } = new();

    }
}

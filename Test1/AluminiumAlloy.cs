using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public class AluminiumAlloy
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ChemicalComposition ChemicalComposition { get; set; }
        public List<MaterialExecution> MaterialExecutions { get; set; } = new();


    }
}

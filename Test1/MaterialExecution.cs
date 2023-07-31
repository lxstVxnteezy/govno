using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public class MaterialExecution
    {
        public Guid MaterialExecutionId { get; set; }
        public string Type { get; set; }
        public List<AluminiumAlloy> AluminiumAlloys { get; set; } = new();

    }
}

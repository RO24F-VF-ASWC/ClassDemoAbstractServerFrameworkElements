using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.TemplateDesignPattern
{
    public class ListADT: AbstractADT
    {
        protected override ICollection<string> CreateCollection()
        {
            return new List<string>();
        }
    }
}

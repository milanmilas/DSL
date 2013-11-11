using System.Collections.Generic;
using System.Linq;

namespace DSL
{
    public class NonTerminalMappingAttribute : MappingAttribute
    {
        public List<MappingAttribute> MappingAttributes { get; set; }

        public override MappingAttribute GetNamedAttribute(string name)
        {
            return MappingAttributes.Select(x => x.GetNamedAttribute(name)).First(attribute => attribute != null);
        }
    }
}

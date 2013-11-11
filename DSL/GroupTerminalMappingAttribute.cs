using System.Collections.Generic;

namespace DSL
{
    class GroupTerminalMappingAttribute : MappingAttribute
    {
        public List<TerminalMappingAttribute> TerminalMappingAttributes { get; set; }

        public override MappingAttribute GetNamedAttribute(string name)
        {
            if (this.Name.Equals(name))
            {
                return this;
            }

            return null;
        }
    }
}

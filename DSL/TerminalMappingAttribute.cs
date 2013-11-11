using System;

namespace DSL
{
    public class TerminalMappingAttribute : MappingAttribute
    {
        public String Value { get; set; }

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

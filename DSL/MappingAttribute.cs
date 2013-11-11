using System;

namespace DSL
{
    public abstract class MappingAttribute
    {
        public String Name { get; set; }

        public abstract MappingAttribute GetNamedAttribute(String name);
    }
}

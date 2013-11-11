using System;
namespace DSL
{

    public abstract class MappingRule
    {
        protected bool result;

        public String Name { get; set; }

        public abstract bool Interpret(MappingContext context);
    }
}

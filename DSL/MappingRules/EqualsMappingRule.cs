namespace DSL.MappingRules
{
    class EqualsMappingRule : TerminalMappingRule
    {
        public override bool Interpret(MappingContext context)
        {
            TerminalMappingAttribute terminalMappingAttribute = context.MappingAttribute.GetNamedAttribute(this.Name) as TerminalMappingAttribute;
            return terminalMappingAttribute != null && terminalMappingAttribute.Value.Equals(this.Value);
        }
    }
}

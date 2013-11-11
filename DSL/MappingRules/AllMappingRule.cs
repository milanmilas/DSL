using System.Collections.Generic;
using System.Linq;

namespace DSL.MappingRules
{
    class AllMappingRule : TerminalMappingRule
    {

        public List<EqualsMappingRule> mappingRules;

        public override bool Interpret(MappingContext context)
        {
            GroupTerminalMappingAttribute groupTerminalMappingAttribute = (GroupTerminalMappingAttribute)context.MappingAttribute.GetNamedAttribute(this.Name);

            List<TerminalMappingAttribute> terminalMappingAttributes = groupTerminalMappingAttribute.TerminalMappingAttributes;

            return mappingRules.All(rule => terminalMappingAttributes.Any(attribute => rule.Value.Equals(attribute.Value)));
        }
    }
}

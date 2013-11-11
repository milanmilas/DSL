using System.Collections.Generic;

namespace DSL.MappingRules
{
    class AndMappingRule : NonTerminalMappingRule
    {
        public AndMappingRule(List<MappingRule> mapping)
        {
            mappingRules = mapping;
            result = true;
        }

        protected override bool Group(bool parResult, bool mappingRuleResult)
        {
            return parResult && mappingRuleResult;
        }
    }
}

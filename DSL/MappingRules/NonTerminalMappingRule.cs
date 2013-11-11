using System.Collections.Generic;

namespace DSL.MappingRules
{
    public abstract class NonTerminalMappingRule : MappingRule
    {
        protected List<MappingRule> mappingRules;

        public override bool Interpret(MappingContext context)
        {

            foreach (var mappingRule in mappingRules)
            {
                result = Group(result, mappingRule.Interpret(context));
            }

            return result;
        }

        protected abstract bool Group(bool parResult, bool mappingRuleResult);
    }
}

using System;
using System.Collections.Generic;

namespace DSL
{
    using DSL.MappingRules;

    class Program
    {
        static void Main()
        {
            MappingAttribute attribute = new NonTerminalMappingAttribute{
                MappingAttributes = new List<MappingAttribute> {new TerminalMappingAttribute { Name = "Trust", Value = "RR8"},
                                                                 new TerminalMappingAttribute { Name = "Ward", Value = "OakWard"},
                                                                new GroupTerminalMappingAttribute {
                                                                    Name = "JobCodes",
                                                                                                    TerminalMappingAttributes = new List<TerminalMappingAttribute>{
                                                                                                                            new TerminalMappingAttribute { Name = "JobCode", Value = "R" },
                                                                                                                            new TerminalMappingAttribute { Name = "JobCode", Value = "C" },
                                                                                                                            new TerminalMappingAttribute { Name = "JobCode", Value = "U" }
                                                                                                    }
                                                                }
                }

            };

            MappingContext ctx = new MappingContext{ MappingAttribute = attribute };

            EqualsMappingRule trustRule = new EqualsMappingRule{ Name = "Trust", Value = "RR8"};
            EqualsMappingRule wardRule = new EqualsMappingRule{ Name = "Ward", Value = "OakWard"};
            AllMappingRule allJobs = new AllMappingRule{ Name = "JobCodes", mappingRules = new List<EqualsMappingRule>{ new EqualsMappingRule{ Name = "JobCode", Value = "R"},
                new EqualsMappingRule{ Name = "JobCode", Value = "C"},
                new EqualsMappingRule{ Name = "JobCode", Value = "U"}
            }};

            List<MappingRule> rules = new List<MappingRule>{ trustRule, wardRule, allJobs };

            MappingRule mr = new AndMappingRule(rules) { Name = "AssignmentMapping" };

            bool result = mr.Interpret(ctx);

            Console.WriteLine("Result: " + result);
        }
    }
}

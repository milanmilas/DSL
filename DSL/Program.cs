using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSL
{
    class Program
    {
        static void Main(string[] args)
        {
            List<MappingAttribute> attributes = new List<MappingAttribute>(){ new MappingAttribute(){ Name = "Trust", Value = "RR8"},
                                                                              new MappingAttribute(){ Name = "Ward", Value = "OakWard"}
                                                                            };
        }
    }
}

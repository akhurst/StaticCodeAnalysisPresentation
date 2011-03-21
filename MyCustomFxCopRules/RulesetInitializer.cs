//-----------------------------------------------------------------------
// <copyright file="ClassNamePlaceholder.cs" company="Improving Enterprises, Inc.">
//     Copyright (c) Improving Enterprises, Inc. All rights reserved.
// </copyright>
// <author>Ben Floyd</author>
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyCustomFxCopRules
{
    using Microsoft.FxCop.Sdk;

    internal abstract class RulesetInitializer : BaseIntrospectionRule
    {
            protected RulesetInitializer(string ruleName)
                : base(ruleName, "MyCustomFxCopRules.RuleMetadata", typeof(RulesetInitializer).Assembly)
           { }
    }
}
//-----------------------------------------------------------------------
// <copyright file="ClassNamePlaceholder.cs" company="Improving Enterprises, Inc.">
//     Copyright (c) Improving Enterprises, Inc. All rights reserved.
// </copyright>
// <author>Ben Floyd</author>
//-----------------------------------------------------------------------
namespace MyCustomFxCopRules
{
    using Microsoft.FxCop.Sdk;

    /// <summary>
    /// A class for initializing the ruleset
    /// </summary>
    internal abstract class RulesetInitializer : BaseIntrospectionRule
    {
        /// <summary>
        /// Initializes a new instance of the RulesetInitializer class.
        /// </summary>
        /// <param name="ruleName">The name of the rule being added to the ruleset</param>
        protected RulesetInitializer(string ruleName)
            : base(ruleName, "MyCustomFxCopRules.RuleMetadata", typeof(RulesetInitializer).Assembly)
        {
        }
    }
}
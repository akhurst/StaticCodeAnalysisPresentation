//-----------------------------------------------------------------------
// <copyright file="EnforceHungarianNotation.cs" company="Improving Enterprises, Inc.">
//     Copyright (c) Improving Enterprises, Inc. All rights reserved.
// </copyright>
// <author>Ben Floyd</author>
//-----------------------------------------------------------------------
namespace MyCustomFxCopRules
{
    using System;
    using Microsoft.FxCop.Sdk;

    /// <summary>
    /// This class scans fields that are not externally visible to ensure they follow hungarian notation
    /// </summary>
    internal sealed class EnforceHungarianNotation : RulesetInitializer
    {
        /// <summary>
        /// Constant used to validate static fields
        /// </summary>
        private const string s_staticFieldPrefix = "s_";

        /// <summary>
        /// Constant used to validate member (non-static) members
        /// </summary>
        private const string s_nonStaticFieldPrefix = "m_";

        /// <summary>
        /// This variable is for testing purposes - the ruleset will fail on this
        /// </summary>
        private static int m_Foo;

        /// <summary>
        /// Initializes a new instance of the EnforceHungarianNotation class.
        /// Gives a name to the rule by passing it to the base class.
        /// </summary>
        public EnforceHungarianNotation()
            : base("EnforceHungarianNotation")
        { }

        /// <summary>
        /// Gets the visibility of members for which this rule is valid
        /// </summary>
        public override Microsoft.FxCop.Sdk.TargetVisibilities TargetVisibility
        {
            get { return TargetVisibilities.NotExternallyVisible; }
        }

        /// <summary>
        /// Check members of a class against the rule and add any problems to the returned collection
        /// </summary>
        /// <param name="member">The member being checked</param>
        /// <returns>A problem collection - the base class implementation</returns>
        public override ProblemCollection Check(Member member)
        {
            var field = member as Field;
            if (field == null)
            {
                // This rule only applies to fields.
                // Return a null ProblemCollection so no violations are reported for this member.
                return null;
            }

            this.CheckFieldName(field, field.IsStatic ? s_staticFieldPrefix : s_nonStaticFieldPrefix);

            // By default the Problems collection is empty so no violations will be reported
            // unless CheckFieldName found and added a problem.
            return Problems;
        }

        /// <summary>
        /// Checks the fieldname to ensure it starts with the proper hungarian notation
        /// </summary>
        /// <param name="field">The field to check</param>
        /// <param name="expectedPrefix">The prefix that is expected on this field</param>
        private void CheckFieldName(Field field, string expectedPrefix)
        {
            if (field.Name.Name.StartsWith(expectedPrefix, StringComparison.Ordinal))
            {
                return;
            }

            Resolution resolution = GetResolution(
                field,  // Field {0} is not in Hungarian notation.
                expectedPrefix  // Field name should be prefixed with {1}.
                );

            var problem = new Problem(resolution);
            Problems.Add(problem);
        }

    }
}


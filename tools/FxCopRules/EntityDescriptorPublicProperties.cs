﻿//---------------------------------------------------------------------
// <copyright file="EntityDescriptorPublicProperties.cs" company="Microsoft">
//      Copyright (C) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.
// </copyright>
//---------------------------------------------------------------------

namespace DataWebRules
{
    using Microsoft.FxCop.Sdk;

    /// <summary>
    /// This rule checks that no call to EntityDescriptor public properties are made at request building time. Instead they should call the equivalent internal method
    /// </summary>
    public class EntityDescriptorPublicPropertiesRule : BaseDataWebRule
    {
        private Method methodUnderCheck;

        /// <summary>Initializes a new <see cref="EntityDescriptorPublicPropertiesRule"/> instance.</summary>
        public EntityDescriptorPublicPropertiesRule()
            : base("EntityDescriptorPublicPropertiesRule")
        {
        }

        /// <summary>Visibility of targets to which this rule commonly applies.</summary>
        public override TargetVisibilities TargetVisibility
        {
            get
            {
                return TargetVisibilities.All;
            }
        }

        /// <summary>Checks type members.</summary>
        /// <param name="member">Member being checked.</param>
        /// <returns>A collection of problems found in <paramref name="member"/> or null.</returns>
        public override ProblemCollection Check(Member member)
        {
            Method method = member as Method;
            if (method == null)
            {
                return null;
            }

            methodUnderCheck = method;
            Visit(method);
            return Problems.Count > 0 ? Problems : null;
        }

        /// <summary>Visits a constructor invocation.</summary>
        /// <param name="cons">Construction.</param>
        /// <returns>Resulting expression to visit.</returns>
        public override void VisitMethodCall(MethodCall methodCall)
        {
            if (methodCall != null)
            {
                MemberBinding callBinding = methodCall.Callee as MemberBinding;
                if (callBinding != null)
                {
                    Method method = callBinding.BoundMember as Method;
                    if (method != null &&
                        method.DeclaringType.FullName == "Microsoft.OData.Client.EntityDescriptor" &&
                        method.Name.Name != "get_Entity" &&
                        method.Name.Name != "get_StreamDescriptors" &&
                        method.Name.Name != "set_ETag" &&
                        method.IsPublic &&
                        method.NodeType == NodeType.Method)
                    {
                        if (methodUnderCheck.DeclaringType.FullName == "Microsoft.OData.Client.BaseSaveResult" ||
                            methodUnderCheck.DeclaringType.FullName == "Microsoft.OData.Client.SaveResult")
                        {
                            this.Problems.Add(new Problem(GetResolution(methodUnderCheck.FullName)));
                        }
                    }
                }
            }

            base.VisitMethodCall(methodCall);
        }
    }
}


﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.Data.Entity.Metadata;
using Remotion.Linq.Clauses.Expressions;

namespace Microsoft.Data.Entity.Query.Internal
{
    public class EntityTrackingInfoFactory : IEntityTrackingInfoFactory
    {
        public virtual EntityTrackingInfo Create(
            QueryCompilationContext queryCompilationContext,
            QuerySourceReferenceExpression querySourceReferenceExpression,
            IEntityType entityType)
        {
            var trackingInfo
                = new EntityTrackingInfo(
                    queryCompilationContext,
                    querySourceReferenceExpression,
                    entityType);

            return trackingInfo;
        }
    }
}

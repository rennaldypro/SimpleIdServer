﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using Microsoft.Extensions.DependencyInjection;
using System;

namespace SimpleIdServer.FastFed.ApplicationProvider.Provisioning.Scim;

public static class FastFedServicesBuilderExtensions
{
    public static FastFedServicesBuilder AddAppProviderScimProvisioning(this FastFedServicesBuilder builder, Action<ScimProvisioningOptions> cb)
    {
        builder.Services.Configure(cb);
        builder.Services.AddTransient<IAppProviderProvisioningService, ScimProvisioningService>();
        return builder;
    }
}

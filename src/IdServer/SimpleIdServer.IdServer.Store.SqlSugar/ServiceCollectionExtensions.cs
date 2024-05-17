﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
using SimpleIdServer.IdServer.Store.SqlSugar;
using SimpleIdServer.IdServer.Stores;

namespace Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddSqlSugarStore(this IServiceCollection services, Action<SqlSugarOptions> action)
    {
        services.Configure(action);
        services.AddScoped<DbContext>();
        services.AddTransient<IRealmRepository, RealmRepository>();
        services.AddTransient<IApiResourceRepository, ApiResourceRepository>();
        return services;
    }
}
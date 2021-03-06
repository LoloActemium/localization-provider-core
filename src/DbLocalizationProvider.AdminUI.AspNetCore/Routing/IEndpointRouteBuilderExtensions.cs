// Copyright (c) Valdis Iljuconoks. All rights reserved.
// Licensed under Apache-2.0. See the LICENSE file in the project root for more information

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace DbLocalizationProvider.AdminUI.AspNetCore.Routing
{
    /// <summary>
    /// Analyzer is happy now
    /// </summary>
    public static class IEndpointRouteBuilderExtensions
    {
        /// <summary>
        /// Use this method if you are col kid and are using EndpointRouting instead of old-school Mvc routing.
        /// </summary>
        /// <param name="builder">EndpointRouting builder</param>
        /// <returns>The same builder to support API call chaining</returns>
        public static IEndpointRouteBuilder MapDbLocalizationAdminUI(this IEndpointRouteBuilder builder)
        {
            var context = builder.ServiceProvider.GetService<UiConfigurationContext>();
            builder.MapDynamicControllerRoute<AdminUIDynamicRouteValueTransformer>(context.RootUrl + "/api/service/{action}");

            return builder;
        }
    }
}

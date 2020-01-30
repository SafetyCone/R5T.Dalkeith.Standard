using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;
using R5T.Dalkeith.Default;


namespace R5T.Dalkeith.Standard
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="IDataDirectoryNameConvention"/> service.
        /// </summary>
        public static IServiceCollection AddDataDirectoryNameConvention(this IServiceCollection services)
        {
            services.AddDefaultDataDirectoryNameConvention();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="IDataDirectoryNameConvention"/> service.
        /// </summary>
        public static ServiceAction<IDataDirectoryNameConvention> AddDataDirectoryNameConventionAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<IDataDirectoryNameConvention>(() => services.AddDataDirectoryNameConvention());
            return serviceAction;
        }
    }
}

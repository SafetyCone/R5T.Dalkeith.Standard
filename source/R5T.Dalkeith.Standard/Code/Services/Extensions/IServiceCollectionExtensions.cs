using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dalkeith.Default;


namespace R5T.Dalkeith.Standard
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddDataDirectoryNameConvention(this IServiceCollection services)
        {
            services.AddSingleton<IDataDirectoryNameConvention, DataDirectoryNameConvention>();

            return services;
        }
    }
}

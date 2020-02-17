using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;

using R5T.Angleterria.Default;


namespace R5T.Angleterria.Standard
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="IVisualStudioStringlyTypedPathPartsOperator"/> service.
        /// </summary>
        public static IServiceCollection AddVisualStudioStringlyTypedPathPartsOperator(this IServiceCollection services)
        {
            services.AddDefaultVisualStudioStringlyTypedPathPartsOperator();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="IVisualStudioStringlyTypedPathPartsOperator"/> service.
        /// </summary>
        public static ServiceAction<IVisualStudioStringlyTypedPathPartsOperator> AddVisualStudioStringlyTypedPathPartsOperatorAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<IVisualStudioStringlyTypedPathPartsOperator>(() => services.AddVisualStudioStringlyTypedPathPartsOperator());
            return serviceAction;
        }
    }
}

using NDK.Auth.ExtensionMethods;
using NDK.Core.Models;
using NDK.Database.Handlers;
using NDK.Database.Models;
using NDK.PublicAuth.ExtensionMethods;
using NDK.PublicAuth.Models;
using NDK.SelfCare.Core.Business;
using NDK.SelfCare.Core.Interfaces.Business;
using NDK.SelfCare.Core.Interfaces.Repository;
using NDK.SelfCare.Core.Repository;

namespace NDK.SelfCare.Config
{
    public static class StartupHelper
    {

        public static void AddInjections(IServiceCollection services, IConfiguration configuration)
        {
            var ndkDbConfig = configuration.GetSection(nameof(NdkDbConnectionConfiguration)).Get<NdkDbConnectionConfiguration>();
            services.AddSingleton<NdkDbConnectionConfiguration>(x => ndkDbConfig!);
            services.AddSingleton<NdkSimpleEntityRepositoryConfig,SelfCareSimpleRepositoryConfig>();

            services.AddNdkPublicAuthServices();
            var ndkTokenConfiguration = configuration.GetSection(nameof(NdkTokenConfiguration)).Get<NdkTokenConfiguration>();
            services.AddNdkAuthServices(ndkTokenConfiguration!);

            services.AddSingleton<NdkDbConnectionFactory>();
            //services.AddSingleton<NdkUser>();

            services.AddTransient<IPersonRepository, PersonRepository>();
            services.AddTransient<IPersonTypeRepository, PersonTypeRepository>();
            services.AddTransient<IPersonBusiness, PersonBusiness>();
            services.AddTransient<IContactRepository, ContactRepository>();
            services.AddTransient<IContactTypeRepository, ContactTypeRepository>();
            services.AddTransient<IDocumentTypeRepository, DocumentTypeRepository>();



            services.AddTransient<IPersonBusiness, PersonBusiness>();

        }

    }
}

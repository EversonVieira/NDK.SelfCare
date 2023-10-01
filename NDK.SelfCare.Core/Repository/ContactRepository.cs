using Microsoft.Extensions.Logging;
using NDK.Core.Models;
using NDK.Database.Base;
using NDK.Database.Handlers;
using NDK.Database.Models;
using NDK.SelfCare.Core.Interfaces.Repository;
using NDK.SelfCare.Domain.Models;

namespace NDK.SelfCare.Core.Repository
{
    public class ContactRepository : NdkSimpleEntityRepository<Contact, NdkUser>,IContactRepository
    {
        public ContactRepository(NdkUser loggedUser, 
                                 NdkDbConnectionFactory connectionHandler, 
                                 NdkSimpleEntityRepositoryConfig config, 
                                 ILogger<NdkSimpleEntityRepository<Contact, NdkUser>> logger) :
            base(loggedUser, connectionHandler, config, logger)
        {
        }
    }
}

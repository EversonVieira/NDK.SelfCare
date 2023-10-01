using Microsoft.Extensions.Logging;
using NDK.Core.Models;
using NDK.Database.Base;
using NDK.Database.Handlers;
using NDK.Database.Models;
using NDK.SelfCare.Domain.Models.Types;

namespace NDK.SelfCare.Core.Repository
{
    public class DocumentTypeRepository : NdkSimpleEntityRepository<DocumentType, NdkUser>
    {
        public DocumentTypeRepository(NdkUser loggedUser, NdkDbConnectionHandler connectionHandler, NdkSimpleEntityRepositoryConfig config, ILogger<NdkSimpleEntityRepository<DocumentType, NdkUser>> logger) : base(loggedUser, connectionHandler, config, logger)
        {
        }
    }
}

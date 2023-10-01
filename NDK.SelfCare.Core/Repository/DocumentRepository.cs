using Microsoft.Extensions.Logging;
using NDK.Core.Models;
using NDK.Database.Base;
using NDK.Database.Handlers;
using NDK.Database.Models;
using NDK.SelfCare.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDK.SelfCare.Core.Repository
{
    public class DocumentRepository : NdkSimpleEntityRepository<Document, NdkUser>
    {
        public DocumentRepository(NdkUser loggedUser, 
                                  NdkDbConnectionHandler connectionHandler, 
                                  NdkSimpleEntityRepositoryConfig config, 
                                  ILogger<NdkSimpleEntityRepository<Document, NdkUser>> logger) : 
            base(loggedUser, connectionHandler, config, logger)
        {
        }
    }


}

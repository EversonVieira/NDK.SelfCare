﻿using Microsoft.Extensions.Logging;
using NDK.Core.Models;
using NDK.Database.Base;
using NDK.Database.Handlers;
using NDK.Database.Models;
using NDK.SelfCare.Core.Interfaces.Repository;
using NDK.SelfCare.Domain.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDK.SelfCare.Core.Repository
{
    public class PersonTypeRepository : NdkSimpleEntityRepository<PersonType, NdkUser>, IPersonTypeRepository
    {
        public PersonTypeRepository(NdkUser loggedUser,
                                    NdkDbConnectionFactory connectionHandler, 
                                    NdkSimpleEntityRepositoryConfig config, 
                                    ILogger<NdkSimpleEntityRepository<PersonType, NdkUser>> logger) : base(loggedUser, connectionHandler, config, logger)
        {
        }
    }
}

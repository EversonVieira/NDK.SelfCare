using Dapper;
using NDK.Core.Models;
using NDK.Database.Base;
using NDK.Database.ExtensionMethods;
using NDK.Database.Handlers;
using NDK.Database.Models;
using NDK.SelfCare.Core.Constants;
using NDK.SelfCare.Core.Interfaces.Repository;
using NDK.SelfCare.Domain.Models;
using System.Collections.Generic;
using NDK.Core.ExtensionMethods;
using System.Data.Common;
using NDK.SelfCare.Domain.Models.Types;
using NDK.SelfCare.Domain.Models.PersonDtos;

namespace NDK.SelfCare.Core.Repository
{
    public class PersonRepository : NdkBaseRepository, IPersonRepository
    {
        private readonly NdkUser _loggedUser;
        private readonly NdkDbConnectionConfiguration _ndkDbConnectionConfiguration;
        private readonly IContactTypeRepository _contactTypeRepository;
        private readonly IDocumentTypeRepository _documentTypeRepository;
        private readonly IPersonTypeRepository _personTypeRepository;

        public PersonRepository(NdkUser loggedUser, 
                                NdkDbConnectionConfiguration ndkDbConnectionConfiguration, 
                                //IContactTypeRepository contactTypeRepository,
                                //IDocumentTypeRepository documentTypeRepository, 
                                IPersonTypeRepository personTypeRepository)
        {
            _loggedUser = loggedUser;
            _ndkDbConnectionConfiguration = ndkDbConnectionConfiguration;
            //_contactTypeRepository = contactTypeRepository;
            //_documentTypeRepository = documentTypeRepository;
            _personTypeRepository = personTypeRepository;
        }

        public NdkListResponse<Person> GetByRequest(NdkRequest request, DbConnection connection)
        {
            var response = new NdkListResponse<Person>();

            var sql = $@"SELECT * FROM PERSON ";

            var requestData = request.GetRequestData(sql, _ndkDbConnectionConfiguration);

            response.Result = connection.Query<Person>(requestData.query, requestData.parameters).ToList();

            if (request.Options.GetValueByKeyOrDefault(RequestOptionsKeys.FULL_ENTITY))
            {
                foreach (Person person in response.Result)
                {
                    var personTypeRequest = new NdkRequest();
                    personTypeRequest.AddFilterGroup(new NdkFilterGroup()
                    {
                        Id = "1",
                        Filters = new List<NdkFilter>
                        {
                            new NdkFilter
                            {
                                PropertyName = nameof(PersonType.Id),
                                Value = person.Type
                            }
                        }
                    });

                    var personTypeResult = _personTypeRepository.GetByRequest(personTypeRequest, connection);

                    if (personTypeResult.HasStopFlowMessages){
                        response.Merge(response);
                        return response;
                    }

                }
            }

            return response;
        }

        public NdkResponse<long> Insert(Person entity, DbConnection connection)
        {
            var response = new NdkResponse<long>();

            return response;
        }

        public NdkResponse<long> Update(Person entity, DbConnection connection)
        {
            var response = new NdkResponse<long>();

            return response;
        }

        public NdkResponse<long> Delete(Person entity, DbConnection connection)
        {
            var response = new NdkResponse<long>();

            return response;
        }
    }


}

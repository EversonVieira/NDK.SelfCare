using NDK.Core.Models;
using NDK.Database.Handlers;
using NDK.SelfCare.Core.Interfaces.Business;
using NDK.SelfCare.Core.Interfaces.Repository;
using NDK.SelfCare.Domain.Models;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDK.SelfCare.Core.Business
{
    public class PersonBusiness : IPersonBusiness
    {

        private IPersonRepository _repository;
        private NdkDbConnectionHandler _ndkDbConnectionHandler;

        public PersonBusiness(IPersonRepository repository, NdkDbConnectionHandler ndkDbConnectionHandler)
        {
            _repository = repository;
            _ndkDbConnectionHandler = ndkDbConnectionHandler;
        }

        public NdkListResponse<Person> GetByRequest(NdkRequest request)
        {
            using (var conn = _ndkDbConnectionHandler.GetDbConnection())
            {
                return _repository.GetByRequest(request, conn);
            }
        }
        

        public NdkResponse<long> Insert(Person entity)
        {
            throw new NotImplementedException();
        }

        public NdkResponse<long> Update(Person entity)
        {
            throw new NotImplementedException();
        }

        public NdkResponse<long> Delete(Person entity)
        {
            throw new NotImplementedException();
        }

        public NdkListResponse<Person> GetAll()
        {
            using (var conn = _ndkDbConnectionHandler.GetDbConnection())
            {
                return _repository.GetByRequest(new NdkRequest(), conn);
            }
        }
    }
}

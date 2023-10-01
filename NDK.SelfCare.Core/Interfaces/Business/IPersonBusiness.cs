using NDK.Core.Interfaces;
using NDK.Core.Models;
using NDK.SelfCare.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDK.SelfCare.Core.Interfaces.Business
{
    public interface IPersonBusiness : INdkBusiness<Person>
    {
        NdkListResponse<Person> GetAll();
    }
}

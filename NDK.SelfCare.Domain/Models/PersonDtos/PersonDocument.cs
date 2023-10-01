using NDK.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDK.SelfCare.Domain.Models.PersonDtos
{
    public class PersonDocument:NdkBaseModel
    {
        public Document? Document { get; set; }
        public Person? Person { get; set; }
    }
}

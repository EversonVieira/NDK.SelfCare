using NDK.Core.Models;

namespace NDK.SelfCare.Domain.Models.PersonDtos
{
    public class PersonContact : NdkBaseModel
    {
        public Contact? Contact { get; set; }
        public Person? Person { get; set; }
    }
}

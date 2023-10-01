using NDK.Core.Models;
using NDK.SelfCare.Domain.Models.Types;

namespace NDK.SelfCare.Domain.Models
{
    public class Contact : NdkBaseModel
    {
        public ContactType? ContactType { get; set; }
        public long Type { get; set; }
        public string? Value { get; set; }
        public bool IsUnique { get; set; }
    }
}

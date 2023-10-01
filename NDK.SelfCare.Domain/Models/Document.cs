using NDK.Core.Models;
using NDK.SelfCare.Domain.Models.Types;

namespace NDK.SelfCare.Domain.Models
{
    public class Document : NdkBaseModel
    {
        public DocumentType? DocumentType { get; set; }
        public long Type { get; set; }
        public string? Value { get; set; }
        public bool IsUnique { get; set; }
    }
}

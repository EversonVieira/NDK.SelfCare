using NDK.Database.Base;
using NDK.Database.Models;
using NDK.SelfCare.Domain.Models.PersonDtos;
using NDK.SelfCare.Domain.Models.Types;

namespace NDK.SelfCare.Config
{
    public class SelfCareSimpleRepositoryConfig : NdkSimpleEntityRepositoryConfig
    {
        public SelfCareSimpleRepositoryConfig() 
        {
            AddMap(typeof(PersonType), "Person_Type");
            AddMap(typeof(DocumentType), "Document_Type");
            AddMap(typeof(ContactType), "Contact_Type");
        }
    }
}

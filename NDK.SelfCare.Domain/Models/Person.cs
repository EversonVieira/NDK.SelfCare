using NDK.Core.Models;
using NDK.SelfCare.Domain.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDK.SelfCare.Domain.Models
{
    public class Person : NdkBaseModel
    {
        public string? Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string? FatherName { get; set; }
        public string? MotherName { get; set; }
        public long Type { get; set; }
        public PersonType? PersonType { get; set; }
        public List<Document>? Documents { get; set; }
        public List<Contact>? Contacts { get; set; }
    }
}

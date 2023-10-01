using NDK.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDK.SelfCare.Domain.Models.Types
{
    public abstract class BaseType:NdkBaseModel
    {
        public string? Key { get; set; }
        public string? Value { get; set; }
    }
}

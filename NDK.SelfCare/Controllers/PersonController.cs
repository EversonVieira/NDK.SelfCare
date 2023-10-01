using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NDK.Core.Models;
using NDK.SelfCare.Core.Business;
using NDK.SelfCare.Core.Interfaces.Business;
using NDK.SelfCare.Domain.Models;

namespace NDK.SelfCare.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonBusiness _personBusiness;

        public PersonController(IPersonBusiness personBusiness)
        {
            _personBusiness = personBusiness;
        }

        [Produces(typeof(NdkListResponse<Person>))]
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_personBusiness.GetAll());
        }
    }
}

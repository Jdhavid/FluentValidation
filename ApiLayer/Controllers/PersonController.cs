using LogicLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ModelLayer;
using System.Collections.Generic;

namespace ApiLayer.Controllers
{
    [Route("api/")]
    [ApiController]
    public class PersonController : ControllerBase
    {

        private readonly ILogger<PersonController> logger;
        private readonly IPersonService personSevice;
        public PersonController(ILogger<PersonController> logger,
                                IPersonService personSevice)
        {
            this.logger = logger;
            this.personSevice = personSevice;
        }


        [HttpPost]
        [Route("GetListPerson")]
        public ActionResult<IEnumerable<string>> GetList([FromBody] PersonRequest request)
        {
            return Ok(personSevice.GetPersons(request));
        }
    }
}

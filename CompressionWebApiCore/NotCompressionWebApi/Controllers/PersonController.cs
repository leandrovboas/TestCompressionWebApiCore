using CompressionCommun.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace NotCompressionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        public IEnumerable<Person> GetPersons() =>
            Person.CreateList();
    }
}
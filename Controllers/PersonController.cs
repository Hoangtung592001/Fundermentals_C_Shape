using WebAPI.DTO;
using WebAPI.Entities;
using WebAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace Authentication.Controllers;

[ApiController]
[Route("person")]
public class PersonController : ControllerBase
{
    private readonly IPersonService _personService;

    public PersonController(IPersonService personService)
    {
        _personService = personService;
    }

    [HttpGet("get-all")]
    public List<Person> GetAll()
    {
        return _personService.GetAll();
    }

    [HttpPost()]
    public Person Create([FromBody] PersonDTO person)
    {
        return _personService.Create(person);
    }

    [HttpDelete()]
    public bool Delete([FromQuery] Guid id)
    {
        return _personService.Delete(id);
    }

    [HttpPut]
    public Person Edit([FromQuery] Guid id, [FromBody] EditPersonDTO person)
    {
        return _personService.Edit(id, person);
    }

    [HttpPost("/filter")]
    public List<Person> Filter(FilterPersonDTO condition)
    {
        return _personService.Filter(condition);
    }
}

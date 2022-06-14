using Models;
using Services;
using Microsoft.AspNetCore.Mvc;
namespace First_Project.Controllers;

[Route("")]
[Route("Elite")]
[Route("NashTech/Elite")]
public class EliteController : Controller
{
    public enum YearType
    {
        LessThan,
        EqualsTo,
        GreaterThan
    }
    private readonly ILogger<EliteController> _logger;

    private readonly IPersonService _personService;

    public EliteController(ILogger<EliteController> logger, IPersonService personService)
    {
        _logger = logger;
        _personService = personService;
    }

    [Route("")]
    [Route("get-all")]
    public IActionResult GetAll()
    {
        return View(_personService.GetAll());
    }

    [Route("get-oldest")]
    public IActionResult GetOldest()
    {
        return new JsonResult(_personService.GetOldest());
    }

    [Route("get-full-names")]
    public IActionResult GetFullNames()
    {
        return new JsonResult(_personService.GetFullNames());
    }

    [Route("get-by-year")]
    public IActionResult GetMemberByYear(int year, YearType yearType)
    {
        switch (yearType)
        {
            case YearType.EqualsTo:
                return RedirectToAction("GetMemberByYear", new { year = year });
            case YearType.GreaterThan:
                return RedirectToAction("GetMemberByYearGreaterThan", new { year = year });
            default:
                return RedirectToAction("GetMemberByYearLessThan", new { year = year });
        }
    }

    [Route("get-by-year-equals-to")]
    public IActionResult GetMemberByYear(int year)
    {
        return new JsonResult(_personService.GetPeopleByBirthYear(year));
    }

    [Route("get-by-year-less-than")]
    public IActionResult GetMemberByYearLessThan(int year)
    {
        return new JsonResult(_personService.GetPeopleByBirthYearLessThan(year));
    }


    [Route("get-by-year-greater-than")]
    public IActionResult GetMemberByYearGreaterThan(int year)
    {
        return new JsonResult(_personService.GetPeopleByBirthYearGreaterThan(year));
    }

    [Route("download-file")]
    public IActionResult DownloadFile()
    {
        var result = _personService.GetDataStream();
        var memoryStream = new MemoryStream(result);
        return new FileStreamResult(memoryStream, "text/csv") { FileDownloadName = "members.csv" };
    }

    [HttpGet("create-new-member")]
    public IActionResult CreateNewMember()
    {
        return View();
    }

    [HttpPost("create-new-member")]
    public IActionResult CreateNewMember(Person person)
    {
        Console.WriteLine(person);
        _personService.CreateNewPerson(person);
        return RedirectToAction("GetAll");
    }

    [HttpGet("edit-info-member")]
    public IActionResult EditInfoMember(int id)
    {
        Person current = _personService.GetOne(id);
        return View(current);
    }

    [HttpPost("edit-info-member")]
    public IActionResult EditInfoMember(Person person)
    {
        _personService.EditInfoMember(person);
        return RedirectToAction("GetAll");
    }

    [HttpGet("delete-member")]
    public IActionResult DeleteMember(int id)
    {
        _personService.DeleteInfoMember(id);
        return RedirectToAction("GetAll");
    }

}

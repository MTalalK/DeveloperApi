using Microsoft.AspNetCore.Mvc;
using DeveloperApi.Models;
using Microsoft.EntityFrameworkCore;

namespace DeveloperApi.Controllers;
[ApiController]
[Route("developers")]
public class DeveloperController : ControllerBase
{
    private readonly DeveloperContext _context;
    public DeveloperController(DeveloperContext context)
    {
        _context = context;
    }

    [HttpGet]
    [Route("get")]
    public IActionResult GetDevelopers()
    {
        List<Developer> developers = _context.Developers.ToList();
        return Ok(developers);
    }

    [HttpPost]
    [Route("save")]
    public IActionResult SubmitForm([FromBody] Developer developerForm)
    {
        _context.Developers.Add(developerForm);
        _context.SaveChanges();
        return Ok(developerForm);
    }
}


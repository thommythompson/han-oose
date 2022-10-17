using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ICDETool.Models;

namespace ICDETool.Controllers;

public class CourseController : Controller
{
    private readonly ILogger<CourseController> _logger;

    public CourseController(ILogger<CourseController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
}


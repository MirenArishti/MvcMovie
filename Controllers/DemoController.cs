using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers;

public class DemoController : Controller
{
    public string Index()
    {
        return "Successfully implemented the independent controller";
    }
}
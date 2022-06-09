using Microsoft.AspNetCore.Mvc;

namespace ViewModelFun.Controllers;

public class HomeController : Controller
{
    [HttpGet("/")]
    public ViewResult Index ()
    {
        return View();
    }



}

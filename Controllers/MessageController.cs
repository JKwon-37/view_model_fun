using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers;

public class MessageController : Controller
{
    [HttpGet("/message")]
    public IActionResult Message ()
    {
        Message displayMessage = new Message()
        {
            SomeMessage = "I am using the ViewModel to display this message!"
        };
        return View(displayMessage);
    }



}
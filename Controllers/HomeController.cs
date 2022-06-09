using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers;

public class HomeController : Controller
{
    [HttpGet("/")]
    public ViewResult Index ()
    {
        return View();
    }

    [HttpGet("/message")]
    public IActionResult Message ()
    {
        Message displayMessage = new Message()
        {
            SomeMessage = "I am using the ViewModel to display this message!  I am using the ViewModel to display this message!  I am using the ViewModel to display this message!  I am using the ViewModel to display this message!  I am using the ViewModel to display this message!"
        };
        return View(displayMessage);
    }

    [HttpGet("/numbers")]
    public IActionResult Numbers()
    {
        Numbers someNumbers = new Numbers();
        someNumbers.oneThruTen = new int[]
         {
            1, 2 , 3, 4, 5, 6, 7, 8, 9, 10
         };
        return View(someNumbers);
    }

    [HttpGet("/users")]
    public IActionResult People()
    {
        Users user1 = new Users()
        {
            FirstName = "Naruto",
            LastName = "Uzumaki"
        };
        Users user2 = new Users()
        {
            FirstName = "Monkey D.",
            LastName = "Luffy"
        };
        Users user3 = new Users()
        {
            FirstName = "Ichigo",
            LastName = "Kurasaki"
        };
        Users user4 = new Users()
        {
            FirstName = "Seto",
            LastName = "Kaiba"
        };

        List<Users> viewModel = new List<Users>()
        {
            user1, user2, user3, user4
        };
        return View("Users", viewModel);
    }
    [HttpGet("/oneuser")]
    public IActionResult onePerson()
    {
         OneUser somePerson = new OneUser()
        {
            FirstName = "Ash",
            LastName = "Ketchum"
        };
        return View("OneUser", somePerson);
    }
}

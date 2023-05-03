using MadLibsGame.Models;
using Microsoft.AspNetCore.Mvc;

public class MadLibsController : Controller
{
    [Route("/")]
    public ActionResult Index()
    {
        return View();
    }

    [Route("/form")]
    public ActionResult Form()
    {
        return View();
    }

    [Route("/story")]
    public ActionResult Story(MadLibs model)
    {
        return View(model);
    }
}

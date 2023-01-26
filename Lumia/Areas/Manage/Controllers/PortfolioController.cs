using Lumia.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lumia.Areas.Manage.Controllers;
[Area("Manage")]
public class PortfolioController : Controller
{
    private readonly LumiaContext _lumiaContext;

    public PortfolioController(LumiaContext lumiaContext)
    {
        _lumiaContext = lumiaContext;
    }
    public IActionResult Index()
    {
        List<Portfolio>portfolios=_lumiaContext.portfolios.ToList();
        return View(portfolios);
    }
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(Portfolio portfolio)
    {
        _lumiaContext.portfolios.Add(portfolio);
        _lumiaContext.SaveChanges();
        return RedirectToAction("index");
    }
}

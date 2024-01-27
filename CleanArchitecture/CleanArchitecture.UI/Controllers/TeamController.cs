using CleanArchitecture.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.UI.Controllers
{
    public class TeamController : Controller
    {
        public ITeamService TeamService { get; set; }
        public TeamController(ITeamService teamService)
        {
            TeamService = teamService;
        }
        public IActionResult Index()
        {
            ViewBag.Teams = TeamService.GetAllTeams();
            return View();
        }
    }
}

using Kaizen.Models;
using Kaizen.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Kaizen.Controllers
{
    public class TeasController : Controller
    {
        //  public IActionResult Index()
        // {
        //     return View();
        //}

        private readonly ISeasonRepository _seasonRepository;
        private readonly ITeaRepository _teaRepository;

        public TeasController(ISeasonRepository seasonRepository, ITeaRepository teaRepository)
        { 
            _teaRepository = teaRepository;
            _seasonRepository = seasonRepository;
        }// end constructor


        public ViewResult List()
        { // we want to view the teas from the repository

            // we now want it to consume the listviewmodel -->.metcore
             return View(_teaRepository.GetAllTeas);
            //  var teaListViewModel= new TeaListViewModel();
            // teaListViewModel.Teas = _teaRepository.GetAllTeas;
            //teaListViewModel.CurrentSeason = "tester";
            //return View(teaListViewModel);


        }// end list 

        public IActionResult Details(int id)
        {
            var tea = _teaRepository.GetTeasById(id);
            if (tea == null) return NotFound();
            return View(tea);
        }// end iAction






    }// end 
}

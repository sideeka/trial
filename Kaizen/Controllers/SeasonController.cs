using Kaizen.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kaizen.Controllers
{
    public class SeasonController : Controller
    {
        

         private readonly ISeasonRepository _seasonRepository;
         private readonly ITeaRepository _teaRepository;

        public SeasonController(ISeasonRepository seasonRepository, ITeaRepository teaRepository)
        {
            _seasonRepository = seasonRepository;
            _teaRepository = teaRepository;
        }


        public ViewResult List2()
        { // we want to view the sweets
            return View(_seasonRepository.GetAllSeasons);
        }


    }// end class


}

using Kaizen.Data;
using System;
using System.Collections.Generic;

namespace Kaizen.Models
{
    public class SeasonRepository:ISeasonRepository
    {
        //  private readonly Data.ApplicationDbContext _appDbcontext;

        //constructor cactor

        //    public SeasonRepository(ApplicationDbContext appDbcontext)
        //      {
        //           _appDbcontext = appDbcontext;
        //        }

        //   public IEnumerable<Season> GetAllSeasons => _appDbcontext.Seasons;


        IEnumerable<Season> ISeasonRepository.GetAllSeasons => new List<Season>
         {
          new Season{SeasonId=0,farmerName = "Jhon", farmerEmail = "jhon@gmail.com", farmerPhoneNumber = "1234567890"},
         new Season{SeasonId=2, farmerName = "tyreece", farmerEmail = "Tyreece@gmail.com", farmerPhoneNumber = "1234567899"},
        new Season{SeasonId=3, farmerName = "Hella", farmerEmail = "Hella@gmail.com", farmerPhoneNumber = "1234567888" }
        
         };
    }// end
}

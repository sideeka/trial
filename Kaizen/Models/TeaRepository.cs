﻿using Kaizen.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Kaizen.Models
{
    public class TeaRepository : ITeaRepository
    {

        //private readonly Data.ApplicationDbContext _appDbContext;

        //public TeaRepository(ApplicationDbContext appdbContext)
        //{
        //    _appDbContext = appdbContext;
        //}

        //public IEnumerable<Tea> GetAllTeas
        //{
        //    get
        //    {
        //        return _appDbContext.Teas.Include(s => s.Season);
        //    }

        //}// end get all sweets

        //public Tea GetTeasById(int teaid) 
        //{
        //return _appDbContext.Teas.FirstOrDefault(s => s.TeaId == teaid);
        //}


        private readonly ISeasonRepository _seasonRepository = new SeasonRepository();

        public IEnumerable<Tea> GetAllTeas => new List<Tea>
                 {//populating the Ienumerable

                     new Tea{TeaId=0,TeaName="Sencha",TeaDescription="greenTea",Price=50.99M,
                              pic="https://www.itoen-global.com/allabout_greentea/img/varieties_lineup01.png",
                     Season=_seasonRepository.GetAllSeasons.ToList()[0],Seasonid=0,Tea_Stock=15 },

                     new Tea{TeaId=1,TeaName="Fukamushi Sencha",TeaDescription="greenTea",Price=55.99M,
                         pic="~/images/sencha.png",
                     Season=_seasonRepository.GetAllSeasons.ToList()[0],Seasonid=0,Tea_Stock=10 },

                     new Tea{TeaId=2,TeaName="Gyokuro",TeaDescription="greenTea",Price=60.99M,
                              pic="~/images/sencha.png",
                     Season=_seasonRepository.GetAllSeasons.ToList()[2],Seasonid=2,Tea_Stock=10 },

                 };

        // public IEnumerable<Sweet> Sweets => throw new NotImplementedException();//*********************




        public Tea GetTeasById(int teaId)
        {
            return GetAllTeas.FirstOrDefault(c => c.TeaId == teaId);
        }//end get id for sweet8
    }
}

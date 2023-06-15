using System.Collections;
using System.Collections.Generic;

namespace Kaizen.Models
{
    public interface ITeaRepository
    {
        // IEnumerable<Tea>GetAll

        IEnumerable<Tea> GetAllTeas { get; }
        //IEnumerable<Tea> GetTeasOnSale { get; }

        //how-->ID

        Tea GetTeasById(int teaId);



    }// end
}

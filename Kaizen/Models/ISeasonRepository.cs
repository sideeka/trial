using System.Collections.Generic;

namespace Kaizen.Models
{
    public interface ISeasonRepository
    {

        IEnumerable<Season> GetAllSeasons { get; }

    }
}

using Kaizen.Models;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Kaizen.ViewModels
{
    public class TeaListViewModel
    {
        // fetch all Teas
        //current Season
        public IEnumerable<Tea> Teas { get; set; }

        public string CurrentSeason { get; set; }

    }//end
}

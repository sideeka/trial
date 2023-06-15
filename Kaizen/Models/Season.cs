using System.Collections.Generic;

namespace Kaizen.Models
{
    public class Season
    {
        public int SeasonId { get; set; }
        public string farmerName { get; set; }
        public string farmerEmail { get; set; }
        public string farmerPhoneNumber { get; set; }
        
        public List<Tea> Teas { get; set; }

    }
}

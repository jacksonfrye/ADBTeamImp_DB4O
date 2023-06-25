using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADBTeamImp_DB4O
{
    public class City
    {
        //attributes
        public int CityID { get; set; }
        public string Name { get; set; }
        public string Country{ get; set; }
        //relationships
        public List<Flight> DepartureFlights{ get; set; }
        public List<Flight> ArrivalFlights{ get; set; }
        public List<Flight> TransitFlights{ get; set; }
    }
}

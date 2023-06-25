using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADBTeamImp_DB4O
{
    public class Flight
    {
        //attributes
        public int FNum { get; set; }
        public int NumStops { get; set; }
        public int NumPassengers { get; set; }
        public string DepartureDate { get; set; }
        public string ArrivalDate { get; set; }
        public List<string> TransitDate { get; set; }
        //relationships
        public City Departure { get; set; }
        public City Arrival { get; set; }
        public List<City> Transit { get; set; }
        public List<Plane> Makes { get; set; }
    }
}

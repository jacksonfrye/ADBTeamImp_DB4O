using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADBTeamImp_DB4O
{
    public class Plane
    {
        //attributes
        public int ID { get; set; }
        public int Capacity { get; set; }
        public int Weight { get; set; }
        public int Year { get; set; }
        public string Model { get; set; }
        //relationships
        public Flight MakeFlight { get; set; }
    }
}

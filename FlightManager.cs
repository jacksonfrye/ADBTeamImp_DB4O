using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Db4objects.Db4o;
using Db4objects.Db4o.Linq;

namespace ADBTeamImp_DB4O
{
    public class FlightManager
    {
        //Db4O
        public static string DbFileName { get; set; }
        public static IObjectContainer Db => Db4oEmbedded.OpenFile(DbFileName);
        public static void CloseDB(IObjectContainer db)
        {
            db.Close();
        }
    }
}

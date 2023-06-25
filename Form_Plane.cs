using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Db4objects.Db4o;
using Db4objects.Db4o.Linq;

namespace ADBTeamImp_DB4O
{
    public partial class Form_Plane : Form
    {
        IObjectContainer db = null;
        IObjectSet result = null;

        public Form_Plane()
        {
            InitializeComponent();
        }
        //Load
        private void Form_Plane_Load(object sender, EventArgs e)
        {
            FlightManager.DbFileName = "ADBTeamImp_FightManager.yap";
            db = FlightManager.Db;

            loadPlane();

        }

        private void loadPlane()
        {
            var plane = new Plane();
            result = db.QueryByExample(plane);
            dataGridView_Plane.DataSource = result;
        }
        //Button
        private void button_Add_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox_ID.Text);
            int capacity = int.Parse(textBox_Capacity.Text);
            int weight = int.Parse(textBox_Weight.Text);
            int year = int.Parse(textBox_Year.Text);
            string missileType = textBox_MissileType.Text;
            int missileNumber = int.Parse(textBox_MissileNumber.Text);

            IList<Plane> planes = (from Plane plane in db
                                  where plane.ID == id
                                  select plane).ToList();
            if (planes != null && planes.Count != 0)
            {
                MessageBox.Show("Plane existed.");
            }
            else
            {
                if (missileType == null || missileNumber == 0)
                {
                    Plane plane = new Plane
                    {
                        ID = id,
                        Capacity = capacity,
                        Weight = weight,
                        Year = year
                    };
                }
                else
                {
                    War_aircraft warAircraft = new War_aircraft
                    {
                        ID = id,
                        Capacity = capacity,
                        Weight = weight,
                        Year = year,
                        MissileType = missileType,
                        MissileNumber = missileNumber
                    };
                }
                db.Store(city);
            }

            loadCity();
        }

    }
}

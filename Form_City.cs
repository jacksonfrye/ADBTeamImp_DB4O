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
    public partial class Form_City : Form
    {
        IObjectContainer db = null;
        IObjectSet result = null;

        public Form_City()
        {
            InitializeComponent();
        }
        //Load
        private void Form_City_Load(object sender, EventArgs e)
        {
            FlightManager.DbFileName = "ADBTeamImp_FightManager.yap";
            db = FlightManager.Db;

            loadCity();
        }

        private void loadCity()
        {
            var city = new City();
            result = db.QueryByExample(city);
            dataGridView_City.DataSource = result;
        }
        //Button
        private void button_Add_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox_CityID.Text);
            string name = textBox_Name.Text;
            string country = textBox_Country.Text;

            IList<City> cities = (from City city in db
                                  where city.CityID == id
                                  select city).ToList();
            if(cities != null && cities.Count != 0)
            {
                MessageBox.Show("City existed.");
            }
            else
            {
                City city = new City
                {
                    CityID = id,
                    Name = name,
                    Country = country
                };
                db.Store(city);
            }

            loadCity();
        }
    }
}

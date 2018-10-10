using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneralVw.Views
{
    public partial class mdGridView : Form
    {
        public mdGridView()
        {
            InitializeComponent();
        }

        private void mdGridView_Load(object sender, EventArgs e)
        {
            List<persona> ls = new List<persona>();
            ls = new List<persona>
            {
                new persona
                {
                    id = 1, apellidos = "Cen ku", ciudad = "Teabo", edad = 21, nacionalidad = "México", nombre = "Leandro Jesus"
                },
                new persona
                {
                    id = 1, apellidos = "Cen ku", ciudad = "Teabo", edad = 21, nacionalidad = "México", nombre = "Leandro Jesus"
                },
                new persona
                {
                    id = 1, apellidos = "Cen ku", ciudad = "Teabo", edad = 21, nacionalidad = "México", nombre = "Leandro Jesus"
                },
                new persona
                {
                    id = 1, apellidos = "Cen ku", ciudad = "Teabo", edad = 21, nacionalidad = "México", nombre = "Leandro Jesus"
                },
                new persona
                {
                    id = 1, apellidos = "Cen ku", ciudad = "Teabo", edad = 21, nacionalidad = "México", nombre = "Leandro Jesus"
                },
                new persona
                {
                    id = 1, apellidos = "Cen ku", ciudad = "Teabo", edad = 21, nacionalidad = "México", nombre = "Leandro Jesus"
                },
                new persona
                {
                    id = 1, apellidos = "Cen ku", ciudad = "Teabo", edad = 21, nacionalidad = "México", nombre = "Leandro Jesus"
                },
                new persona
                {
                    id = 1, apellidos = "Cen ku", ciudad = "Teabo", edad = 21, nacionalidad = "México", nombre = "Leandro Jesus"
                },
                new persona
                {
                    id = 1, apellidos = "Cen ku", ciudad = "Teabo", edad = 21, nacionalidad = "México", nombre = "Leandro Jesus"
                },
                new persona
                {
                    id = 1, apellidos = "Cen ku", ciudad = "Teabo", edad = 21, nacionalidad = "México", nombre = "Leandro Jesus"
                },
                new persona
                {
                    id = 1, apellidos = "Cen ku", ciudad = "Teabo", edad = 21, nacionalidad = "México", nombre = "Leandro Jesus"
                }
            };

            bunifuCustomDataGrid1.DataSource = ls;
        }
    }


    public class persona
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string ciudad { get; set; }
        public string nacionalidad { get; set; }
        public int edad { get; set; }
    }
}

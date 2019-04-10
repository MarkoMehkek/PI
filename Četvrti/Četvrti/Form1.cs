using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Četvrti
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        List<Parovi> listaParovaaa = new List<Parovi>();
        private void GumbUnesi_Click(object sender, EventArgs e)
        {
           
            Parovi p = new Parovi(PoljeZaUnosprvog.Text);
            p.OdrediParove();
            listaParovaaa.Add(p);
            string izraz = " ";
            foreach (var item in listaParovaaa)
            {
                izraz += item.Prvi + " - " + item.Par + Environment.NewLine;
                Rezultat.Text = izraz;
            }
            PoljeZaUnosprvog.Clear();
        }
    }
}

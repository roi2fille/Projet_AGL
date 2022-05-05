using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pratique
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bonjour");
            Article art1 = new Article("ART1", "Cahier brouillon", float.Parse("1,9"));
            MessageBox.Show(art1.PrixArt1.ToString());
        }
    }
}

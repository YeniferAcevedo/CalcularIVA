using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularIVA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            Double vlrproducto = Double.Parse(txtvlrproducto.Text);
            Double vlriva = 0.19;
            Double vlrfinal = 0;

            vlrfinal = (vlrproducto * vlriva) + vlrproducto;

            lblvalorfinal.Text = Convert.ToString(String.Format("{0:n0}", vlrfinal));
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtvlrproducto.Text = String.Empty;
            lblvalorfinal.Text = "0";
            txtvlrproducto.Focus();
        }
    }
}

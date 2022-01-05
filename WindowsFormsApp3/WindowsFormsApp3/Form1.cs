using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Pizza p;
        private void btnCrear_Click(object sender, EventArgs e)
        {
            p = new Pizza();
            p.Tamaño = txtTamaño.Text;
            p.TieneQuesoExtra = chkQuesoExtra.Checked;
            p.EsMasaDelgada = chkMasaDelgada.Checked;
            txtPrecio.Text = p.Costo.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            p.AgregarIngrediente(txtIngrediente.Text);
            lstIngredientes.DataSource = null;
            lstIngredientes.DataSource = p.Ingredientes;
            txtPrecio.Text = p.Costo.ToString();

        }
    }
}

using Infraestructura.Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductosM1.Forms
{
    public partial class FmrProductosManageY : Form
    {
        private ProductoModel productoModel; //se usa este objeto porque tiene todos los metodos , usando Infraestructura
        public FmrProductosManageY()
        {
            InitializeComponent();
        }

        private void cmbFinder_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (cmbFinder.SelectedIndex)
            {
                case 0:
                    pnlFindById.Visible = true;
                    pnlCaducity.Visible = false;
                    pnlMeassureUnit.Visible = false;
                    pnlMeassureUnit.Visible = false;
                    break;
                case 1:
                    pnlFindById.Visible = false;
                    pnlCaducity.Visible = false;
                    pnlMeassureUnit.Visible = true;
                    pnlMeassureUnit.Visible = false;
                    break;
                case 2:
                    pnlFindById.Visible = false;
                    pnlCaducity.Visible = false;
                    pnlMeassureUnit.Visible = false;
                    pnlMeassureUnit.Visible = true;
                    break;
                case 3:
                    pnlFindById.Visible = false;
                    pnlCaducity.Visible = true;
                    pnlMeassureUnit.Visible = false;
                    pnlMeassureUnit.Visible = false;
                    break;

            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FmrProducto fmrProducto = new FmrProducto();
            fmrProducto.PModel = productoModel;
            fmrProducto.ShowDialog(); //Muestra un cuadro de dialogo

            rtbProductoview.Text = ProductoModel.GetProductoAsJson(); //I dont know
        }
    }
}

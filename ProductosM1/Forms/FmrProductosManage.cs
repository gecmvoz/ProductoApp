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
    public partial class FmrProductosManage : Form
    {
        private ProductoModel productoModel; //se usa este objeto porque tiene todos los metodos 


        public FmrProductosManage()
        {
            productoModel = new productoModel;
            InitializeComponent();

        }
        //los panel deben de tener el mismo tamaño parq ue se puedan ver
        private void TxtId_TextChanged(object sender, EventArgs e) //para que no se muestre en el formulario, true para que se vya mostrando uno por uno. 
        {
            switch(cmbFinder.SelectedIndex)
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

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FmrProducto fmrProducto = new FmrProducto();
            fmrProducto.PModel = productoModel;
            fmrProducto.ShowDialog();

            rtbProductoView.Text
        }
    }
}

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
    public partial class FmrProducto : Form
    {
        public ProductoModel PModel { get; set; }
        public FmrProducto()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Producto p = new Producto()
            {
                Id =PModel.GetlastProductoId() +1,
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                Existencia = (int) nudExistencia.Value,
                Precio = nudPrecio.Value,
                FechaVencimiento = dtpCaducity
            }
        }

        private void FmrProducto_Load(object sender, EventArgs e)
        {
            cmbUnidadMedida.Items.AddRange(Enum.GetValues(typeof(UnidadMedida)))
                                                .Cast<>
        }
    }
}

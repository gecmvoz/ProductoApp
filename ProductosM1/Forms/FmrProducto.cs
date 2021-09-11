﻿using Domain.Entities;
using Domain.Enum;
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
    public partial class FmrProducto : Form
    {
        public ProductoModel PModel { get; set; } //Di referencia a infraestructura
        public FmrProducto()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Producto p = new Producto()
            {
                Id = PModel.GetLastProductoId() + 1,
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                Existencia = (int)nudExistencia.Value,
                Precio = nudPrecio.Value,
                FechaVencimiento = dtpCaducity.Value,
                UnidadMedida = (UnidadMedida)cmbUnidadMedida.SelectedIndex //using Domain.enum
            };

            PModel.Add(p);

            Dispose(); //Metodo que cierra la ventana
        }

        private void FmrProducto_Load(object sender, EventArgs e)
        {
            cmbUnidadMedida.Items.AddRange(Enum.GetValues(typeof(UnidadMedida)).Cast<object>().ToArray());
                                                
        }

    
    }
}

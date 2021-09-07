using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructura.Productos
{
    class ProductoModel
    {
        private Producto[] productos;

        #region CRUD
        public void Add(Producto p)
        {
            Add(p, ref productos);
        }


        public int Update(Producto p)
        {
            if (p == null)
            {
                throw new ArgumentException("El producto no puede see null");

            }
            int index = GetIndexById(p.Id);
            if(index < 0)
            {
                throw new Exception($"El producto con id {p.Id} no se encuentra.");
            }
            productos[index] = p;
            return index;
        }
        public Producto[] GetAll()
        {
            return productos;
        }


        #endregion



        #region Private Method

        //public void Add(Producto p, )

        private void Add(Producto p, ref Producto[] pds) //agregar por referencia es  cualquier cambio que haga en el metodo va a surgir o afectar donde lo  estoy pasand
        {
           
            if (pds == null)
            {
                pds = new Producto[1];
                pds[pds.Length - 1] = p;
                pds[pds.Length - 1] = p;
                return; 
            }

            Producto[] tmp = new Producto[pds.Length + 1];
            Array.Copy(pds, tmp, pds.Length);
            tmp[tmp.Length - 1] = p;
            return;
        }

        private int GetIndexById(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("El id no se puede ser negativo o cero");

            }

            int index = int.MinValue, i = 0; //representa el valor mas pequeño en un campo
            if (productos == null)
            {
                return index;
            }

            foreach (Producto p in productos)
            {
                if (p.Id == id)
                {
                    index = i;
                }
                i++;
            }

            return index;
        }

        #endregion

    }
}

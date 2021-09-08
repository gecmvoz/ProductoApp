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
        public void Add(Producto p) //AGREGAR
        {
            Add(p, ref productos);
        }


        public int Update(Producto p) //ACTUALIZA
        {
            if (p == null)
            {
                throw new ArgumentException("El producto no puede see null");

            }
            int index = GetIndexById(p.Id);//OBTIENE LA POSICION DEL ID
            if(index < 0)
            {
                throw new Exception($"El producto con id {p.Id} no se encuentra.");
            }
            productos[index] = p;
            return index;
        }

        public bool Delete(Producto p) //Crea un temporal y no presenta el ultimo 
        {
            if (p == null)
            {
                throw new ArgumentException("El producto no puede see null");

            }
            int index = GetIndexById(p.Id);
            if (index < 0)
            {
                throw new Exception($"El producto con id {p.Id} no se encuentra.");
            }
            if (index != productos.Length - 1) // si el arreglo es diferente a 
            {
                productos[index] = productos[productos.Length - 1];

            }
            Producto[] tmp = new Producto[productos.Length - 1];
            Array.Copy(productos, tmp, tmp.Length);
            productos = tmp;

            return productos.Length == tmp.Length;
        }
        public Producto[] GetAll()//IMPRIME TODO EL OBJETO
        {
            return productos;
        }


        #endregion



        #region Private Method

        

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

        #region Queries
        public Producto GetProductoById(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException($"El Id: {id} no es valido.");
            }
            int index = GetIndexById(id); // si el id es mayor lo manda a buscar, si no lo encuentra manda unnull en caso contrario devuelve la posicion del producto

            return index <= 0 ? null : productos[index];
       
        }
        #endregion

    }
}

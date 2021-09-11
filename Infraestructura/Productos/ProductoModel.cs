using Domain.Entities;
using Domain.Enum;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructura.Productos
{
    public class ProductoModel
    {
        private Producto[] productos;

        #region CRUD

        //Add, Delete, Update

        public void Add(Producto p) //AGREGAR
        {
            Add(p, ref productos);
        }


        public int Update(Producto p) //ACTUALIZAR
        {
            if (p == null)
            {
                throw new ArgumentException("El producto no puede see null");

            }
            int index = GetIndexById(p.Id);//OBTIENE LA POSICION DEL ID

            if (index < 0)
            {
                throw new ArgumentException($"El producto con id {p.Id} no se encuentra.");
            }
            productos[index] = p;
            return index;
        }

        public bool Delete(Producto p) // ELIMINAR
        {
            if (p == null)
            {
                throw new ArgumentException("El producto no puede see null");

            }
            int index = GetIndexById(p.Id); //Obtiene la posicion por Id

            if (index < 0)
            {
                throw new ArgumentException($"El producto con id {p.Id} no se encuentra.");
            }

            //Crea un arreglo de Objecto temporal y hace una copia de arreglo exceptuando el ultimo 

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



        //Separa por referenia es decir; cualquier cambio que se haga va afectar al lugar donde se hace la referencia 
        private void Add(Producto p, ref Producto[] pds) //agregar por referencia es  cualquier cambio que haga en el metodo va a surgir o afectar donde lo  estoy pasando
        {

            if (pds == null)
            {
                pds = new Producto[1];
                pds[pds.Length - 1] = p;
                return;
            }

            Producto[] tmp = new Producto[pds.Length + 1];
            Array.Copy(pds, tmp, pds.Length);
            tmp[tmp.Length - 1] = p;
            pds = tmp;
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

            int index = GetIndexById(id); // si el Id es mayor lo manda a buscar, si no lo encuentra manda un null en caso contrario devuelve la posicion del producto

            return index <= 0 ? null : productos[index];
        }

        public Producto[] GetProductosByUnidad(UnidadMedida um) //tmp es null no tiene absolutamente nada.
        {
            Producto[] tmp = null;
            if (productos == null)
            {
                return tmp;
            }
            foreach (Producto p in productos)
            {
                if (p.UnidadMedida == um)
                {
                    Add(p, ref tmp); // llama el metodo add que se hizo anterior 
                }
            }
            return tmp;
        }

        public Producto[] GetProductosByVencimiento(DateTime dt)
        {
            Producto[] tmp = null;
            if (productos == null)
            {
                return tmp;
            }
            foreach (Producto p in productos) //compare to devuelve 1, -1 y 0 osea que toma todo lo que es menos o igual a la fecha, es recomendable usar el comparer to
            {
                if (p.FechaVencimiento.CompareTo(dt) <= 0)
                {
                    Add(p, ref tmp);
                }
            }
            return tmp;
        }

        public Producto[] GetProductoByRangoPrecio(decimal start, decimal end)//desde donde comienza hasta donde termina
        {
            Producto[] tmp = null;
            if (productos == null)
            {
                return tmp;

            }
            foreach (Producto p in productos)
            {
                if (p.Precio >= start && p.Precio <= end)
                {
                    Add(p, ref tmp);
                }
            }
            return tmp;
        }
        public Producto[] GetProductosOrderByPrecio()
        {
            Array.Sort(productos, new Producto.ProductoPrecioComparer());
                return productos;
        }

        public string GetProductoAsJson() 
        {
            return JsonConvert.SerializeObject(productos);
        }
        public int GetLastProductoId()
        {
            return productos == null ? 0 : productos[productos.Length - 1].Id;
        }

        #endregion




    }
}

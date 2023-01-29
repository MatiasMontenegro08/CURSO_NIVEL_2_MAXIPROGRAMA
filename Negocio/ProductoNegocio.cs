using Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ProductoNegocio
    {
        public List<Producto> Listar()
        {
            List<Producto> listaprod = new List<Producto>();
            AccesoDatos conectar = new AccesoDatos();
            try
            {
                conectar.setearConsulta("select A.Id, A.Codigo, A.Nombre, A.Descripcion, A.IdMarca, A.IdCategoria, M.Descripcion Marca, C.Descripcion Categoria, A.ImagenUrl, A.Precio from ARTICULOS A, CATEGORIAS C, MARCAS M where A.IdCategoria = C.Id and A.IdMarca = M.Id");
                conectar.ejecutarLectura();

                while (conectar.Lector.Read())
                {
                    double precio;
                    Producto temporal = new Producto();
                    temporal.Id = (int)conectar.Lector["Id"];
                    temporal.Codigo = (string)conectar.Lector["Codigo"];
                    temporal.Nombre = (string)conectar.Lector["Nombre"];
                    temporal.Detalle = (string)conectar.Lector["Descripcion"];

                    temporal.Marca = new Marca();
                    temporal.Marca.Id = (int)conectar.Lector["IdMarca"];
                    temporal.Marca.Descripcion = (string)conectar.Lector["Marca"];

                    temporal.Categoria = new Categoria();
                    temporal.Categoria.Id = (int)conectar.Lector["IdCategoria"];
                    temporal.Categoria.Descripcion = (string)conectar.Lector["Categoria"];

                    temporal.Imagen = (string)conectar.Lector["ImagenUrl"];
                    temporal.Preciodb = (decimal)conectar.Lector["Precio"];
                    precio = Convert.ToDouble(temporal.Preciodb);
                    temporal.Precio = precio;
                    listaprod.Add(temporal);
                }
                return listaprod;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conectar.cerrarconexion();
            }
        }   
        public List<Producto> Filtrar(string campo, string criterio, string filtro)
        {
            List<Producto> lista = new List<Producto>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "select A.Id, A.Nombre, A.Codigo, A.Descripcion, A.ImagenUrl, A.Precio, M.Descripcion Marca, C.Descripcion Categoria, A.IdMarca, A.IdCategoria from ARTICULOS A, MARCAS M, CATEGORIAS C where A.IdMarca = M.Id and A.IdCategoria = C.Id and ";
                if (campo == "Precio")
                {
                    switch (criterio)
                    {
                        case "Mayor a":
                            consulta += "A.Precio > " + filtro;
                            break;
                        case "Menor a":
                            consulta += "A.Precio < " + filtro;
                            break;
                        default:
                            consulta += "A.Precio = " + filtro;
                            break;
                    }
                }
                else if (campo == "Marca")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "M.Descripcion like '" + filtro + "%'";
                            break;
                        case "Termina con":
                            consulta += "M.Descripcion like '%" + filtro + "'";
                            break;
                        default:
                            consulta += "M.Descripcion like '%" + filtro + "%'";
                            break;
                    }
                }
                else
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "C.Descripcion like '" + filtro + "%'";
                            break;
                        case "Termina con":
                            consulta += "C.Descripcion like '%" + filtro + "'";
                            break;
                        default:
                            consulta += "C.Descripcion like '%" + filtro + "%'";
                            break;
                    }
                }
                datos.setearConsulta(consulta);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    double precio;
                    Producto filt = new Producto();
                    filt.Id = (int)datos.Lector["Id"];
                    filt.Codigo = (string)datos.Lector["Codigo"];
                    filt.Nombre = (string)datos.Lector["Nombre"];
                    filt.Detalle = (string)datos.Lector["Descripcion"];

                    filt.Marca = new Marca();
                    filt.Marca.Id = (int)datos.Lector["IdMarca"];
                    filt.Marca.Descripcion = (string)datos.Lector["Marca"];

                    filt.Categoria = new Categoria();
                    filt.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    filt.Categoria.Descripcion = (string)datos.Lector["Categoria"];

                    filt.Imagen = (string)datos.Lector["ImagenUrl"];
                    filt.Preciodb = (decimal)datos.Lector["Precio"];
                    precio = Convert.ToDouble(filt.Preciodb);
                    filt.Precio = precio;
                    lista.Add(filt);
                }
                datos.Lector.Close();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void eliminarFijo(int prodcto)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("delete from ARTICULOS where Id = @id");
                datos.setearParametros("@id", prodcto);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void agregar(Producto nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) values (@Cod, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @Img, @Precio)");
                datos.setearParametros("@Cod", nuevo.Codigo);
                datos.setearParametros("@Nombre", nuevo.Nombre);
                datos.setearParametros("@Descripcion", nuevo.Detalle);
                datos.setearParametros("@IdMarca", nuevo.Marca.Id);
                datos.setearParametros("@IdCategoria", nuevo.Categoria.Id);
                datos.setearParametros("@Img", nuevo.Imagen);
                datos.setearParametros("@Precio", nuevo.Precio);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarconexion();
            }
        }
        public void modificar(Producto seleccionado) 
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update ARTICULOS set Codigo = @Cod, Nombre = @Nombre, Descripcion = @Descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria, ImagenUrl = @Img, Precio = @Precio where Id = @Id");
                datos.setearParametros("@Cod", seleccionado.Codigo);
                datos.setearParametros("@Nombre", seleccionado.Nombre);
                datos.setearParametros("@Descripcion", seleccionado.Detalle);
                datos.setearParametros("@IdMarca", seleccionado.Marca.Id);
                datos.setearParametros("@IdCategoria", seleccionado.Categoria.Id);
                datos.setearParametros("@Img", seleccionado.Imagen);
                datos.setearParametros("@Precio", seleccionado.Precio);
                datos.setearParametros("@Id", seleccionado.Id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally 
            { 
                datos.cerrarconexion();
            }
        }
    }
}

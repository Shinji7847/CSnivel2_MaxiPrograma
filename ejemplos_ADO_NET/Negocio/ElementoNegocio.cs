using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ElementoNegocio
    {
        public List<Elemento> listar()
        {
            List<Elemento> listaElemento = new List<Elemento>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta();

                return listaElemento;
            }
            catch (Exception ex)
            {

                throw ex;
            } 
        }
    }
}

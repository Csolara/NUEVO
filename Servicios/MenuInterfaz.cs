using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUEVO.Servicios
{
    /// <summary>
    /// Interfaz con la relación de métodos de la funcionalida menú
    /// 250923 - csl
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Método quemuestra mensaje de bienvenida al cajero
        /// 250923 - csl
        /// </summary>
        public void mostrarMensajeBienvenida();

        /// <summary>
        /// Método que muestra el menú y recoge la selección del usuario
        /// 260923 - csl
        /// </summary>
        /// <returns></returns>
        public int mostrarMenuYSeleccion();



    }
}

using SistemaPsicoaprende.AppDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPsicoaprende.Controlador
{
    public class CtrlLogin
    {

        public static Usuario BuscarUsuario(string nomUsuario)
        {
            // Instanciamos la clase AppDatoContext de la capa de datos
            SistemaPsicoaprendeConnection contexto = new SistemaPsicoaprendeConnection();
            // Realizamos la consulta para obtener el usuario por nombre de usuario
            Usuario usuario = contexto.Usuario.FirstOrDefault(u => u.NomUsuario == nomUsuario);
            //Retorna el nombre del usuario
            return usuario;
        }//Fin del método de BuscarUsuario
    }//Fin de la clase
}

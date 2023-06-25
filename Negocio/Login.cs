using SistemaPsicoaprende.AppDatos;
using SistemaPsicoaprende.Controlador;

namespace SistemaPsicoaprende.Negocio
{
    public class Login
    {

        public bool ValidarCredenciales(string nombre, string contraseña)
        {
            //CtrlLogin login = new CtrlLogin();

            // Llamamos al método ObtenerUsuario por nombre de usuario
            Usuario usr = CtrlLogin.BuscarUsuario(nombre);

            if (usr != null)
            {
                // Si se encontró un usuario con el nombre de usuario proporcionado, comparamos las contraseñas cifradas
                //string passwordCifrada = Encrypt(contraseña); // Ciframos la contraseña ingresada

                if (usr.PassWrd == contraseña)
                {
                    // Las contraseñas coinciden, la validación es exitosa
                    return true;
                }
            }
            // Las credenciales son inválidas
            return false;
        }//Fin del método de ValidarCredenciales

    }//Fin de la clase
}

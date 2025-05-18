
using System;

namespace Dominio
{
    public class Usuario
    {
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public DateTime FechaUltimoLogin { get; set; }

        // Constructor agregado por el_entrerriano para inicializar el usuario
        public Usuario(string nombreUsuario, string contraseña)
        {
            NombreUsuario = nombreUsuario;
            Contraseña = contraseña;
            FechaUltimoLogin = DateTime.MinValue;
        }
    }
}
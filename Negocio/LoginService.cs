using System;

namespace Servicios
{
    public class LoginService
    {
        public bool EsPasswordValida(string pass)
        {
            // Validación agregada por emmanuel: mínimo 8 caracteres
            return pass.Length >= 8;
        }
    }
}

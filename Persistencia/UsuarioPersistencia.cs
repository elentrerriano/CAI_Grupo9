using Datos;
using Persistencia.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class UsuarioPersistencia
    {
        public Credencial login(String username)
        {
            DataBaseUtils dataBaseUtils = new DataBaseUtils();
            List<String> registros = dataBaseUtils.BuscarRegistro(username);

            // Validar que haya registros antes de acceder
            if (registros.Count == 0)
            {
                throw new Exception("No se encontró ningún registro para el usuario: " + username);
                // O también podés retornar null si preferís manejarlo desde otra capa:
                // return null;
            }

            Credencial credencial = new Credencial(registros[0]);
            return credencial;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Text;

namespace Operaciones
{
    /// <summary>
    /// Respositorio de los estatus de operaciones de tarjetas de credito
    /// </summary>

    public static class EstatusOperaciones
    {
        public const string _exitoso = "K120";
        public const string _clienteNoEncontrado = "P4";
        public const string _errorDelSistema = "K15";
    }
}
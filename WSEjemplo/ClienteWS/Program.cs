using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteWS
{
    class Program
    {
        static void Main(string[] args)
        {
            using (WSPersonas.WSPersonasClient client = new WSPersonas.WSPersonasClient())
            {
                var Persona = client.ObtenerPersona(1);
                var Nombre = Persona.Nombre;
            }
        }
    }
}

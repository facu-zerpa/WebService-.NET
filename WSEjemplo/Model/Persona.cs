using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [DataContract]
    public class Persona: BaseRespuesta
    {
        public int IdPersona { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Documento { get; set; }
        public int IdTipoDocumento { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}

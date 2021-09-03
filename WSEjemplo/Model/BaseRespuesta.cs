using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [DataContract]
    public class BaseRespuesta
    {
        public string MensajeRespuesta { get; set; }
        public string Error { get; set; }
    }
}

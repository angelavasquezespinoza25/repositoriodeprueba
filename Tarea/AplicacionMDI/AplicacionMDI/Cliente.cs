using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionMDI
{
  class Cliente
  {

    public string Nombres { get; set; }
    public string Apellidos { get; set; }
    public DocumentoPersona TipoDocumento { get; set; }
    public string NumeroDocumento { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public bool Vigente { get; set; }

    public string Documento
        {
            get
            {
                return this.TipoDocumento.Siglas;
            }
        }

    public string NombresCompletos
        {
            get
            {
                return this.Nombres + " " + this.Apellidos;
            }
        }


  }
}

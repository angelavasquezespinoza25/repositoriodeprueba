using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace AplicacionMDI
{
  class Trabajador
  {

    public string Nombres { get; set; }
    public string Apellidos { get; set; }
    public DocumentoPersona TipoDocumento { get; set; }
    public string NumeroDocumento { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public string Celular { get; set; }
    public string Correo { get; set; }  //validar con expresiones regulares
    public bool Vigente { get; set; }

        public string Documento
        {
            get
            {
                return this.TipoDocumento.Nombre;
            }
        }

        public string NombresCompletos
        {
            get
            {
                return this.Nombres + " " + this.Apellidos;
            }
        }

        //Validando el correo con expresiones regulares
        public bool emailvalido(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

    }
}

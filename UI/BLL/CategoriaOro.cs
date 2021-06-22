using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BLL
{
    internal class CategoriaOroDescuento : Cliente
    {
        //Declaro Atributo
        float aplicarDescuento = 0.03f;
        //Declaro Propiedad
        public float AplicarDescuento
        {
            get { return aplicarDescuento; }
            set { aplicarDescuento = value; }
        }

        public CategoriaOroDescuento(string cNombre, string cApellido, string
       cTipoDeDocumento, long cNumeroDocumento, string cDireccion, string cNacionalidad, string
       cOcupacion, string cCorreoEletronico, long cTelefono, string cFechaDeNacimiento) :
       base(cNombre, cApellido, cTipoDeDocumento, cNumeroDocumento, cDireccion, cNacionalidad,
       cOcupacion, cCorreoEletronico, cTelefono, cFechaDeNacimiento)
        {
        }
    }
}
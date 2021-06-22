using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BLL
{
    class CuentaCorriente : Cuenta
    {
        public CuentaCorriente(string cNombre, string cApellido, string cTipoDeDocumento,
       long cNumeroDocumento, string cDireccion, string cNacionalidad, string cOcupacion, string
       cCorreoEletronico, long cTelefono, string cFechaDeNacimiento)
        : base(cNombre, cApellido, cTipoDeDocumento, cNumeroDocumento, cDireccion,
       cNacionalidad, cOcupacion, cCorreoEletronico, cTelefono, cFechaDeNacimiento)
        {
        }
        public override double Depositar
        {
            get => throw new NotImplementedException(); set
=> throw new NotImplementedException();
        }
        public override double Extraer
        {
            get => throw new NotImplementedException(); set =>
throw new NotImplementedException();
        }
        public override double Tranferir
        {
            get => throw new NotImplementedException(); set
=> throw new NotImplementedException();
        }
        public override double Pagar
        {
            get => throw new NotImplementedException(); set =>
throw new NotImplementedException();
        }
    }
}
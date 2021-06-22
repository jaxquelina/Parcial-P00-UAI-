using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BLL
{
    class TarjetaDebito : Movimiento
    {
        public TarjetaDebito(string cNombre, string cApellido, string cTipoDeDocumento, long
       cNumeroDocumento, string cDireccion, string cNacionalidad, string cOcupacion, string
       cCorreoEletronico, long cTelefono, string cFechaDeNacimiento) : base(cNombre, cApellido,
       cTipoDeDocumento, cNumeroDocumento, cDireccion, cNacionalidad, cOcupacion,
       cCorreoEletronico, cTelefono, cFechaDeNacimiento)
        {
        }
        public override double realizarMovimiento
        {
            get => throw new
NotImplementedException(); set => throw new NotImplementedException();
        }
        public override double calcularMovimiento
        {
            get => throw new
NotImplementedException(); set => throw new NotImplementedException();
        }
        public override double consultarSaldo
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        public override double AplicarDescuento
        {
            get => throw new
NotImplementedException(); set => throw new NotImplementedException();
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
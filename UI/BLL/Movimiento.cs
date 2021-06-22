using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BLL
{
    public abstract class Movimiento : Cuenta
    {
        //Declaro los atributos
        private string tipoTarjeta;
        private long numeroTarjeta;
        private int codSeguridadTarjeta;
        private string fechaVencimiento;
        private string marcaTarjeta;
        private long monto;
        public string tipoMovimiento;
        protected Movimiento(string cNombre, string cApellido, string cTipoDeDocumento, long
       cNumeroDocumento, string cDireccion, string cNacionalidad, string cOcupacion, string
       cCorreoEletronico, long cTelefono, string cFechaDeNacimiento) : base(cNombre, cApellido,
       cTipoDeDocumento, cNumeroDocumento, cDireccion, cNacionalidad, cOcupacion,
       cCorreoEletronico, cTelefono, cFechaDeNacimiento)
        {
        }
        //Declaro la propiedad Monto:
        public long Monto
        {
            get { return monto; }
            set { monto = value; }
        }
        //Declaro los metodos que seran tambien abstractos
        public abstract double realizarMovimiento { get; set; }
        public abstract double calcularMovimiento { get; set; }
        public abstract double consultarSaldo { get; set; }
        public abstract double AplicarDescuento { get; set; }
    }
}
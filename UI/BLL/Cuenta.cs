using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BLL
{
    /*Cuenta sera una clase Asociacion
    La clase Cuenta va a HEREDAR de la clase cliente esto lo hago con los ':'
    No pode heredar de la clase movimientos ya que en C# solo se permite que
    se herede de una SOLA clase.*/
    public abstract class Cuenta : Cliente
    {
        //Declaro los atributos
        private double saldoContable;
        private int numeroCuenta;
        private long numeroCbu;
        private string moneda;
        private double movimientosPendientes;
        private string denominacion;
        private int cantidadTitulares;
        //Con este constructor tomare los atributos de la clase Cliente
        protected Cuenta(string cNombre, string cApellido, string cTipoDeDocumento, long
       cNumeroDocumento, string cDireccion, string cNacionalidad, string cOcupacion, string
       cCorreoEletronico, long cTelefono, string cFechaDeNacimiento)
        : base(cNombre, cApellido, cTipoDeDocumento, cNumeroDocumento, cDireccion,
       cNacionalidad, cOcupacion, cCorreoEletronico, cTelefono, cFechaDeNacimiento)
        {
        }
        //Declaro los metodos Abstractos
        public abstract double Depositar { get; set; }
        public abstract double Extraer { get; set; }
        public abstract double Tranferir { get; set; }
        public abstract double Pagar { get; set; }
    }
}
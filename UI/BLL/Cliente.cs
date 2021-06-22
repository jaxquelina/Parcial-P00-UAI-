using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BLL
{
    public class Cliente
    {
        //Declaro los atributos
        public string nombre;
        public string apellido;
        public string tipoDocumento;
        public long numeroDeDocumento;
        public string direccion;
        public string nacionalidad;
        public string ocupacion;
        public string correoElectronico;
        public long telefono;
        public string fechaDeNacimiento;
        //Detallo todas las propiedades
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string TipoDeDocumento
        {
            get { return tipoDocumento; }
            set { tipoDocumento = value; }
        }
        public long NumeroDeDocumento
        {
            get { return numeroDeDocumento; }
            set { numeroDeDocumento = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public string Nacionalidad
        {
            get { return nacionalidad; }
            set { nacionalidad = value; }
        }
        public string Ocupacion
        {
            get { return ocupacion; }
            set { ocupacion = value; }
        }
        public string CorreoElectronico
        {
            get { return correoElectronico; }
            set { correoElectronico = value; }
        }
        public long Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string FechaDeNacimiento
        {
            get { return fechaDeNacimiento; }
            set { fechaDeNacimiento = value; }
        }
        /*Creo el constructor para pasarle estos campos del cliente a la clase
        Cuentas*/
        public Cliente(string cNombre, string cApellido, string cTipoDeDocumento, long
       cNumeroDocumento, string cDireccion, string cNacionalidad, string cOcupacion, string
       cCorreoEletronico, long cTelefono, string cFechaDeNacimiento)
        {
            Nombre = cNombre;
            Apellido = cApellido;
            TipoDeDocumento = cTipoDeDocumento;
            NumeroDeDocumento = cNumeroDocumento;
            Direccion = cDireccion;
            Nacionalidad = cNacionalidad;
            Ocupacion = cOcupacion;
            CorreoElectronico = cCorreoEletronico;
            Telefono = cTelefono;
            FechaDeNacimiento = cFechaDeNacimiento;
        }
        //Declaro Metodo: DescuentoPorMovimientos
        public double DescuentoPorMovimientos { get; set; }
    }
}
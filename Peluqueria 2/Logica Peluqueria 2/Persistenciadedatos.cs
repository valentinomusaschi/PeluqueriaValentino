using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Logica_Peluqueria_2
{
    public class Persistenciadedatos
    {
        readonly string RutaListacliente = @"C:\Users\Usuario\OneDrive\Escritorio\proyecto practica\Peluqueria 2\Listacliente.txt";
        readonly string RutaListaencargado = @"C:\Users\Usuario\OneDrive\Escritorio\proyecto practica\Peluqueria 2\Listaencargado.txt";
        readonly string RutaListapeluquero = @"C:\Users\Usuario\OneDrive\Escritorio\proyecto practica\Peluqueria 2\Listapeluquero.txt";
        readonly string RutaListapersona = @"C:\Users\Usuario\OneDrive\Escritorio\proyecto practica\Peluqueria 2\Listapersona.txt";
        readonly string RutaListaprecio = @"C:\Users\Usuario\OneDrive\Escritorio\proyecto practica\Peluqueria 2\Listaprecio.txt";
        readonly string RutaListaproducto = @"C:\Users\Usuario\OneDrive\Escritorio\proyecto practica\Peluqueria 2\Listaproducto.txt";
        readonly string RutaListasecretaria = @"C:\Users\Usuario\OneDrive\Escritorio\proyecto practica\Peluqueria 2\Listasecretaria.txt";
        readonly string RutaListastock = @"C:\Users\Usuario\OneDrive\Escritorio\proyecto practica\Peluqueria 2\Listastock.txt";
        readonly string RutaListaturno = @"C:\Users\Usuario\OneDrive\Escritorio\proyecto practica\Peluqueria 2\Listaturno.txt";
        public void InicializarArchivos()
        {
            if (!File.Exists(RutaListacliente))
            {
                File.Create(RutaListacliente).Close();
            }
            if (!File.Exists(RutaListaencargado))
            {
                File.Create(RutaListaencargado).Close();
            }
            if (!File.Exists(RutaListapeluquero))
            {
                File.Create(RutaListapeluquero).Close();
            }
            if (!File.Exists(RutaListapersona))
            {
                File.Create(RutaListapersona).Close();
            }
            if (!File.Exists(RutaListaprecio))
            {
                File.Create(RutaListaprecio).Close();
            }
            if (!File.Exists(RutaListaproducto))
            {
                File.Create(RutaListaproducto).Close();
            }
            if (!File.Exists(RutaListasecretaria))
            {
                File.Create(RutaListasecretaria).Close();
            }
            if (!File.Exists(RutaListastock))
            {
                File.Create(RutaListastock).Close();
            }
            if (!File.Exists(RutaListaturno))
            {
                File.Create(RutaListaturno).Close();
            }
        }
        //lectura de archivos 
        public List<Cliente> LeerArchivoCliente()
        {
            string locationFile = RutaListacliente;
            using (StreamReader reader = new StreamReader(locationFile))
            {
                string content = reader.ReadToEnd();
                List<Cliente> Listacliente = JsonConvert.DeserializeObject<List<Cliente>>(content);
                return Listacliente;
            }
        }
        public List<Encargado> LeerArchivoEncargado()
        {
            string locationFile = RutaListaencargado;
            using (StreamReader reader = new StreamReader(locationFile))
            {
                string content = reader.ReadToEnd();
                List<Encargado> Listaencargado = JsonConvert.DeserializeObject<List<Encargado>>(content);
                return Listaencargado;
            }
        }
        public List<Peluquero> LeerArchivoPeluquero()
        {
            string locationFile = RutaListapeluquero;
            using (StreamReader reader = new StreamReader(locationFile))
            {
                string content = reader.ReadToEnd();
                List<Peluquero> Listapeluquero = JsonConvert.DeserializeObject<List<Peluquero>>(content);
                return Listapeluquero;
            }
        }
        public List<Persona> LeerArchivoPersona()
        {
            string locationFile = RutaListapersona;
            using (StreamReader reader = new StreamReader(locationFile))
            {
                string content = reader.ReadToEnd();
                List<Persona> Listapersona = JsonConvert.DeserializeObject<List<Persona>>(content);
                return Listapersona;
            }
        }
        public List<Precio> LeerArchivoPrecio()
        {
            string locationFile = RutaListaprecio;
            using (StreamReader reader = new StreamReader(locationFile))
            {
                string content = reader.ReadToEnd();
                List<Precio> Listaprecio = JsonConvert.DeserializeObject<List<Precio>>(content);
                return Listaprecio;
            }
        }
        public List<Producto> LeerArchivoProducto()
        {
            string locationFile = RutaListaproducto;
            using (StreamReader reader = new StreamReader(locationFile))
            {
                string content = reader.ReadToEnd();
                List<Producto> Listaproducto = JsonConvert.DeserializeObject<List<Producto>>(content);
                return Listaproducto;
            }
        }
        public List<Secretaria> LeerArchivoSecretaria()
        {
            string locationFile = RutaListasecretaria;
            using (StreamReader reader = new StreamReader(locationFile))
            {
                string content = reader.ReadToEnd();
                List<Secretaria> Listasecretaria = JsonConvert.DeserializeObject<List<Secretaria>>(content);
                return Listasecretaria;
            }
        }
        public List<Stock> LeerArchivoStock()
        {
            string locationFile = RutaListastock;
            using (StreamReader reader = new StreamReader(locationFile))
            {
                string content = reader.ReadToEnd();
                List<Stock> Listastock = JsonConvert.DeserializeObject<List<Stock>>(content);
                return Listastock;
            }
        }
        public List<Turno> LeerArchivoTurno()
        {
            string locationFile = RutaListaturno;
            using (StreamReader reader = new StreamReader(locationFile))
            {
                string content = reader.ReadToEnd();
                List<Turno> Listaturno = JsonConvert.DeserializeObject<List<Turno>>(content);
                return Listaturno;
            }
        }
        //Guardar archivos 
        public void GuardarArchivoCliente(List<Cliente> Listaclliente)
        {
            string locationFile = RutaListacliente;
            using (StreamWriter writer = new StreamWriter(locationFile, false))
            {
                string jsonContent = JsonConvert.SerializeObject(Listaclliente);
                writer.Write(jsonContent);
            }
        }

        public void GuardarArchivoEncargado(List<Encargado> Listaencargado)
        {
            string locationFile = RutaListaencargado;
            using (StreamWriter writer = new StreamWriter(locationFile, false))
            {
                string jsonContent = JsonConvert.SerializeObject(Listaencargado);
                writer.Write(jsonContent);
            }
        }

        public void GuardarArchivoPeluquero(List<Peluquero> Listapeluquero)
        {
            string locationFile = RutaListapeluquero;
            using (StreamWriter writer = new StreamWriter(locationFile, false))
            {
                string jsonContent = JsonConvert.SerializeObject(Listapeluquero);
                writer.Write(jsonContent);
            }
        }

        public void GuardarArchivoPersona(List<Persona> Listapersona)
        {
            string locationFile = RutaListapersona;
            using (StreamWriter writer = new StreamWriter(locationFile, false))
            {
                string jsonContent = JsonConvert.SerializeObject(Listapersona);
                writer.Write(jsonContent);
            }
        }

        public void GuardarArchivoPrecio(List<Precio> Listaprecio)
        {
            string locationFile = RutaListaprecio;
            using (StreamWriter writer = new StreamWriter(locationFile, false))
            {
                string jsonContent = JsonConvert.SerializeObject(Listaprecio);
                writer.Write(jsonContent);
            }
        }

        public void GuardarArchivoProducto(List<Producto> Listaproducto)
        {
            string locationFile = RutaListaproducto;
            using (StreamWriter writer = new StreamWriter(locationFile, false))
            {
                string jsonContent = JsonConvert.SerializeObject(Listaproducto);
                writer.Write(jsonContent);
            }
        }

        public void GuardarArchivoSecretaria(List<Secretaria> Listasecretaria)
        {
            string locationFile = RutaListasecretaria;
            using (StreamWriter writer = new StreamWriter(locationFile, false))
            {
                string jsonContent = JsonConvert.SerializeObject(Listasecretaria);
                writer.Write(jsonContent);
            }
        }

        public void GuardarArchivoStock(List<Stock> Listastock)
        {
            string locationFile = RutaListastock;
            using (StreamWriter writer = new StreamWriter(locationFile, false))
            {
                string jsonContent = JsonConvert.SerializeObject(Listastock);
                writer.Write(jsonContent);
            }
        }

        public void GuardarArchivoTurno(List<Turno> Listaturno)
        {
            string locationFile = RutaListaturno;
            using (StreamWriter writer = new StreamWriter(locationFile, false))
            {
                string jsonContent = JsonConvert.SerializeObject(Listaturno);
                writer.Write(jsonContent);
            }
        }

        //internal List<Producto> LeerArchivoProducto()
        //{
            //throw new NotImplementedException();
        //}
    }
}
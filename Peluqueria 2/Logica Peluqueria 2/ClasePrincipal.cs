using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_Peluqueria_2
{
    public class ClasePrincipal
    {
        List<Cliente> Listacliente = new List<Cliente>();

        // Alta cliente 
        public void AltaCliente(Cliente personanueva)
        {
            Listacliente = ValidarCliente(); 
            Cliente nuevo = new Cliente();
            nuevo.nombre = personanueva.nombre;
            nuevo.telefono = personanueva.telefono;
            nuevo.gmail = personanueva.gmail;
            nuevo.dni = personanueva.dni;
            nuevo.direccion = personanueva.direccion;
            nuevo.id = personanueva.id;
            nuevo.idpersona = personanueva.idpersona;
            nuevo.idturno = personanueva.idturno;
            nuevo.idcompra = personanueva.idcompra;
            Listacliente. Add(nuevo);
            InstanciaPersistenciadedatos.GuardarArchivoCliente(Listacliente);
        }
        //modificacion Cliente 
        public void modificarcliente(Cliente personanueva, int ID)
        {
            Listacliente = ValidarCliente();
            var clientemodificado = Listacliente.Find(x => ID == x.id);
            clientemodificado.nombre = personanueva.nombre;
            clientemodificado.telefono = personanueva.telefono;
            clientemodificado.gmail = personanueva.gmail;
            clientemodificado.dni = personanueva.dni;
            clientemodificado.direccion = personanueva.direccion;
            clientemodificado.id = ID;
            clientemodificado.idpersona = personanueva.idpersona;
            clientemodificado.idturno = personanueva.idturno;
            clientemodificado.idcompra = personanueva.idcompra;

            var clienteEliminado = Listacliente.Find(x => ID == x.id);
            Listacliente.Remove(clienteEliminado);
            Listacliente.Add(clientemodificado);
            InstanciaPersistenciadedatos.GuardarArchivoCliente(Listacliente);
        }

        //Dar de baja Cliente 
        public void BajaCliente(int ID)
        {
            Listacliente = ValidarCliente();
            var clienteEliminado = Listacliente.Find(x => ID == x.id);
            Listacliente.Remove(clienteEliminado);
            InstanciaPersistenciadedatos.GuardarArchivoCliente(Listacliente);
        }

        List<Encargado> Listaencargado = new List<Encargado>();

            // Alta Encargado
        public void AltaEncargado(Encargado personanueva)
        {
            Encargado nuevo = new Encargado();
            nuevo.telefono = personanueva.telefono;
            nuevo.gmail = personanueva.gmail;
            nuevo.dni = personanueva.dni;
            nuevo.direccion = personanueva.direccion;
            nuevo.id = personanueva.id;
            nuevo.idpersona = personanueva.idpersona;
            nuevo.id_de_personasacargos = personanueva.id_de_personasacargos;
            Listaencargado.Add(nuevo);
            InstanciaPersistenciadedatos.GuardarArchivoEncargado(Listaencargado);
        }

        //modificacion Encargado
        public void modificarEncargado(Encargado personanueva, int ID, int ID_DE_PERSONASACARGOS)
        {
            var encargadomodificado = Listaencargado.Find(x => ID == x.id);

            encargadomodificado.telefono = personanueva.telefono;
            encargadomodificado.gmail = personanueva.gmail;
            encargadomodificado.dni = personanueva.dni;
            encargadomodificado.direccion = personanueva.direccion;
            encargadomodificado.id = ID;
            encargadomodificado.idpersona = personanueva.idpersona;
            encargadomodificado.id_de_personasacargos = ID_DE_PERSONASACARGOS;

            var encargadoEliminado = Listaencargado.Find(x => ID == x.id);
            Listaencargado.Remove(encargadoEliminado);
            Listaencargado.Add(encargadomodificado);
            InstanciaPersistenciadedatos.GuardarArchivoEncargado(Listaencargado);
        }
        
        //Dar de baja encargado
        public void BajaEncargado(int ID)
        {
            var encargadoEliminado = Listaencargado.Find(x => ID == x.id);
            Listaencargado.Remove(encargadoEliminado);
            InstanciaPersistenciadedatos.GuardarArchivoEncargado(Listaencargado);

        }
        
        List<Peluquero> Listapeluquero = new List<Peluquero>();

        // Alta peluquero
        public void AltaPeluquero(Peluquero personanueva)
        {
            Peluquero nuevo = new Peluquero();
            nuevo.telefono = personanueva.telefono;
            nuevo.gmail = personanueva.gmail;
            nuevo.dni = personanueva.dni;
            nuevo.direccion = personanueva.direccion;
            nuevo.id = personanueva.id;
            nuevo.idpersona = personanueva.idpersona;
            nuevo.id_desu_encargado = personanueva.id_desu_encargado;
            Listapeluquero.Add(nuevo);
            InstanciaPersistenciadedatos.GuardarArchivoPeluquero(Listapeluquero);
        }
        //modificacion peluquero
        public void modificarPeluquero(Peluquero personanueva, int ID, int ID_DESU_ENCARGADO)
        {
            var peluqueromodificado = Listapeluquero.Find(x => ID == x.id);
            peluqueromodificado.telefono = personanueva.telefono;
            peluqueromodificado.gmail = personanueva.gmail;
            peluqueromodificado.dni = personanueva.dni;
            peluqueromodificado.direccion = personanueva.direccion;
            peluqueromodificado.id =ID;
            peluqueromodificado.idpersona = personanueva.idpersona;
            peluqueromodificado.id_desu_encargado = ID_DESU_ENCARGADO;

            var peluqueroEliminado = Listapeluquero.Find(x => ID == x.id);
            Listapeluquero.Remove(peluqueroEliminado);
            Listapeluquero.Add(peluqueromodificado);
            InstanciaPersistenciadedatos.GuardarArchivoPeluquero(Listapeluquero);
        }
        //Dar de baja peluquero
        public void BajaPeluquero(int ID)
        {
            var PeluqueroEliminado = Listapeluquero.Find(x => ID == x.id);
            Listapeluquero.Remove(PeluqueroEliminado);
            InstanciaPersistenciadedatos.GuardarArchivoPeluquero(Listapeluquero);
        }

       List<Persona> Listapersona = new List<Persona>();

        // Alta persona
        public void AltaPersona(Persona personanueva)
        {
            Persona nuevo = new Persona();
            nuevo.nombre = personanueva.nombre;
            nuevo.telefono = personanueva.telefono;
            nuevo.gmail = personanueva.gmail;
            nuevo.dni = personanueva.dni;
            nuevo.direccion = personanueva.direccion;
            Listapersona.Add(nuevo);
            InstanciaPersistenciadedatos.GuardarArchivoPersona(Listapersona);
        }
        //modificacion persona
        public void modificarPersona(Persona personanueva, int DNI)
        {
            var personamodificado = Listapersona.Find(x => DNI == x.dni);
            personamodificado.nombre = personanueva.nombre;
            personamodificado.telefono = personanueva.telefono;
            personamodificado.gmail = personanueva.gmail;
            personamodificado.dni = DNI;
            personamodificado.direccion = personanueva.direccion;

            var personaEliminado = Listapersona.Find(x => DNI == x.dni);
            Listapersona.Remove(personaEliminado);
            Listapersona.Add(personamodificado);
            InstanciaPersistenciadedatos.GuardarArchivoPersona(Listapersona);
        }

        //Dar de baja persona
        public void BajaPersona(int DNI)
        {
            var PersonaEliminado = Listapersona.Find(x => DNI == x.dni);
            Listapersona.Remove(PersonaEliminado);
            InstanciaPersistenciadedatos.GuardarArchivoPersona(Listapersona);
        }

        List<Precio> Listaprecio = new List<Precio>();

        // Alta precio
        public void AltaPrecio(Precio personanueva)
        {
            Precio nuevo = new Precio();
            nuevo.id = personanueva.id;
            nuevo.idproducto = personanueva.idproducto;
            nuevo.fecha = personanueva.fecha;
            nuevo.importe = personanueva.importe;
            Listaprecio.Add(nuevo);
            InstanciaPersistenciadedatos.GuardarArchivoPrecio(Listaprecio);
        }

        //modificacion precio 
        public void modificarPrecio(Precio personanueva, int ID, int IDPRODUCTO)
        {
            var preciomodificado = Listaprecio.Find(x => ID == x.id);

            preciomodificado.id = ID;
            preciomodificado.idproducto = IDPRODUCTO;
            preciomodificado.fecha = personanueva.fecha;
            preciomodificado.importe = personanueva.importe;

            var precioEliminado = Listaprecio.Find(x => ID == x.id);
            Listaprecio.Remove(precioEliminado);
            Listaprecio.Add(preciomodificado);
            InstanciaPersistenciadedatos.GuardarArchivoPrecio(Listaprecio);
        }
        //Dar de baja precio
        public void BajPrecio(int ID)
        {
            var precioEliminado = Listaprecio.Find(x => ID == x.id);
            Listaprecio.Remove(precioEliminado);
            InstanciaPersistenciadedatos.GuardarArchivoPrecio(Listaprecio);
        }

        List<Producto> Listaproducto = new List<Producto>();

        // Alta producto
        public void AltaProducto(Producto personanueva)
        {
            Listaproducto = ValidarProducto();
            Producto nuevo = new Producto();
            nuevo.id = personanueva.id;
            nuevo.idcliente = personanueva.idcliente;
            nuevo.tipo = personanueva.tipo;
            nuevo.cantidad = personanueva.cantidad;
            Listaproducto.Add(nuevo);
            InstanciaPersistenciadedatos.GuardarArchivoProducto(Listaproducto);
        }
        //modificacion Producto 
        public void modificarproducto(Producto personanueva, int ID)
        {
            Listaproducto = ValidarProducto();
            var productomodificado = Listaproducto.Find(x => ID == x.id);
            productomodificado.id = ID;
            productomodificado.idcliente = personanueva.idcliente;
            productomodificado.tipo = personanueva.tipo;
            productomodificado.cantidad = personanueva.cantidad;

            var productoEliminado = Listaproducto.Find(x => ID == x.id);
            Listaproducto.Remove(productoEliminado);
            Listaproducto.Add(productomodificado);
            InstanciaPersistenciadedatos.GuardarArchivoProducto(Listaproducto);
        }
        //Dar de baja producto
        public void BajaProducto(int ID)
        {
            Listaproducto = ValidarProducto();
            var productoEliminado = Listaproducto.Find(x => ID == x.id);
            Listaproducto.Remove(productoEliminado);
            InstanciaPersistenciadedatos.GuardarArchivoProducto(Listaproducto);
        }
        
        List<Secretaria> Listasecretaria = new List<Secretaria>();

        // Alta Secretaria
        public void AltaSecretaria(Secretaria personanueva)
        {
            Secretaria nuevo = new Secretaria();
            nuevo.id = personanueva.id;
            nuevo.idpersona = personanueva.idpersona;
            nuevo.id_desu_encargado = personanueva.id_desu_encargado;
            nuevo.telefono = personanueva.telefono;
            nuevo.gmail = personanueva.gmail;
            nuevo.dni = personanueva.dni;
            nuevo.direccion = personanueva.direccion;
            Listasecretaria.Add(nuevo);
            InstanciaPersistenciadedatos.GuardarArchivoSecretaria(Listasecretaria);
        }

        //modificacion secretaria 
        public void modificarsecretaria(Secretaria personanueva, int ID, int ID_DESU_ENCARGADO)
        {
            var secretariamodificado = Listasecretaria.Find(x => ID == x.id);

            secretariamodificado.telefono = personanueva.telefono;
            secretariamodificado.id = ID;
            secretariamodificado.idpersona = personanueva.idpersona;
            secretariamodificado.gmail = personanueva.gmail;
            secretariamodificado.dni = personanueva.dni;
            secretariamodificado.direccion = personanueva.direccion;
            secretariamodificado.id_desu_encargado= ID_DESU_ENCARGADO;

            var secretariaEliminado = Listasecretaria.Find(x => ID == x.id);
            Listasecretaria.Remove(secretariaEliminado);
            Listasecretaria.Add(secretariamodificado);
            InstanciaPersistenciadedatos.GuardarArchivoSecretaria(Listasecretaria);
        }

        //Dar de baja secretaria
        public void BajaSecretaria(int ID)
        {
            var secretariaEliminado = Listasecretaria.Find(x => ID == x.id);
            Listasecretaria.Remove(secretariaEliminado);
            InstanciaPersistenciadedatos.GuardarArchivoSecretaria(Listasecretaria);
        }

        List<Stock> Listastock = new List<Stock>();

        // Alta Stock
        public void AltaStock(Stock personanueva)
        {
            Stock nuevo = new Stock();
            nuevo.id = personanueva.id;
            nuevo.id_producto = personanueva.id_producto;
            nuevo.tipo = personanueva.tipo;
            nuevo.canidad = personanueva.canidad;
            Listastock.Add(nuevo);
            InstanciaPersistenciadedatos.GuardarArchivoStock(Listastock);
        }

        //modificacion stock 
        public void modificarstock(Stock personanueva, int ID, int ID_PRODUCTO)
        {
            var stockmodificado = Listastock.Find(x => ID == x.id);

            stockmodificado.id = ID;
            stockmodificado.id_producto = ID_PRODUCTO;
            stockmodificado.tipo = personanueva.tipo;
            stockmodificado.canidad = personanueva.canidad;

            var stockEliminado = Listastock.Find(x => ID == x.id_producto);
            Listastock.Remove(stockEliminado);
            Listastock.Add(stockmodificado);
            InstanciaPersistenciadedatos.GuardarArchivoStock(Listastock);

        }
        //Dar de baja stock
        public void Bajastock(int ID)
        {
            var stockEliminado = Listastock.Find(x => ID == x.id);
            Listastock.Remove(stockEliminado);
            InstanciaPersistenciadedatos.GuardarArchivoStock(Listastock);
        }

        List<Turno> Listaturno = new List<Turno>();

        // Alta turno
        public void AltaTurno(Turno personanueva)
        {
            Listaturno = ValidarTurno();
            Turno nuevo = new Turno();
            nuevo.id = personanueva.id;
            nuevo.idcliente = personanueva.idcliente;
            nuevo.fecha = personanueva.fecha;
            nuevo.costo = personanueva.costo;
            nuevo.demora_estimada = personanueva.demora_estimada;
            nuevo.hora_disponible = personanueva.hora_disponible;
            Listaturno.Add(nuevo);
            InstanciaPersistenciadedatos.GuardarArchivoTurno(Listaturno);
        }

        //modificacion turno
        public void modificarturno(Turno personanueva, int ID)
        {
            Listaturno = ValidarTurno();
            var turnomodificado = Listaturno.Find(x => ID == x.id);

            turnomodificado.id = ID;
            turnomodificado.idcliente = personanueva.idcliente;
            turnomodificado.fecha = personanueva.fecha;
            turnomodificado.costo = personanueva.costo;
            turnomodificado.demora_estimada = personanueva.demora_estimada;
            turnomodificado.hora_disponible = personanueva.hora_disponible;

            var turnoEliminado = Listaturno.Find(x => ID == x.id);
            Listaturno.Remove(turnoEliminado);
            Listaturno.Add(turnomodificado);
            InstanciaPersistenciadedatos.GuardarArchivoTurno(Listaturno);
        }

        //Dar de baja turno
        public void Bajaturno(int ID)
        {
            Listaturno = ValidarTurno();
            var turnoEliminado = Listaturno.Find(x => ID == x.id);
            Listaturno.Remove(turnoEliminado);
            InstanciaPersistenciadedatos.GuardarArchivoTurno(Listaturno);
        }

        Persistenciadedatos InstanciaPersistenciadedatos = new Persistenciadedatos();

        public void RellenarLista()
        {
            Listacliente = InstanciaPersistenciadedatos.LeerArchivoCliente();
            Listapeluquero = InstanciaPersistenciadedatos.LeerArchivoPeluquero();
            Listapersona = InstanciaPersistenciadedatos.LeerArchivoPersona();
            Listaprecio = InstanciaPersistenciadedatos.LeerArchivoPrecio();
            Listasecretaria = InstanciaPersistenciadedatos.LeerArchivoSecretaria();
            Listaproducto = InstanciaPersistenciadedatos.LeerArchivoProducto();
            Listastock = InstanciaPersistenciadedatos.LeerArchivoStock();
            Listaturno = InstanciaPersistenciadedatos.LeerArchivoTurno();
            Listaencargado = InstanciaPersistenciadedatos.LeerArchivoEncargado();
        }

        //validaciones 
        public List<Cliente> ValidarCliente()
        {
            Listacliente = InstanciaPersistenciadedatos.LeerArchivoCliente();
            if (Listacliente == null)
            {
                List<Cliente> NuevaListaCliente = new List<Cliente>();
                return NuevaListaCliente;
            }
            
            
                return Listacliente;
            
        }

        public List<Peluquero> ValidarPeluquero()
        {
            Listapeluquero = InstanciaPersistenciadedatos.LeerArchivoPeluquero();
            if (Listapeluquero == null)
            {
                List<Peluquero> NuevaListaPeluquero = new List<Peluquero>();
                return NuevaListaPeluquero;
            }
            else
            {
                return Listapeluquero;
            }
        }

        public List<Persona> ValidarPersona()
        {
            Listapersona = InstanciaPersistenciadedatos.LeerArchivoPersona();
            if (Listapersona == null)
            {
                List<Persona> NuevaListaPersona = new List<Persona>();
                return NuevaListaPersona;
            }
            else
            {
                return Listapersona;
            }
        }

        public List<Precio> ValidarPrecio()
        {
            Listaprecio = InstanciaPersistenciadedatos.LeerArchivoPrecio();
            if (Listaprecio == null)
            {
                List<Precio> NuevaListaPrecio = new List<Precio>();
                return NuevaListaPrecio;
            }
            else
            {
                return Listaprecio;
            }
        }

        public List<Producto> ValidarProducto()
        {
            Listaproducto = InstanciaPersistenciadedatos.LeerArchivoProducto();
            if (Listaproducto == null)
            {
                List<Producto> NuevaListaProducto = new List<Producto>();
                return NuevaListaProducto;
            }
            else
            {
                return Listaproducto;
            }
        }

        public List<Secretaria> ValidarSecretaria()
        {
            Listasecretaria = InstanciaPersistenciadedatos.LeerArchivoSecretaria();
            if (Listasecretaria == null)
            {
                List<Secretaria> NuevaListaSecretaria = new List<Secretaria>();
                return NuevaListaSecretaria;
            }
            else
            {
                return Listasecretaria;
            }
        }

        public List<Stock> ValidarSrock()
        {
            Listastock = InstanciaPersistenciadedatos.LeerArchivoStock();
            if (Listastock == null)
            {
                List<Stock> NuevaListaStock = new List<Stock>();
                return NuevaListaStock;
            }
            else
            {
                return Listastock;
            }
        }

        public List<Turno> ValidarTurno()
        {
            Listaturno = InstanciaPersistenciadedatos.LeerArchivoTurno();
            if (Listaturno == null)
            {
                List<Turno> NuevaListaTurno = new List<Turno>();
                return NuevaListaTurno;
            }
            else
            {
                return Listaturno;
            }
        }

        public List<Encargado> ValidarEncargado()
        {
            Listaencargado = InstanciaPersistenciadedatos.LeerArchivoEncargado();
            if (Listaencargado == null)
            {
                List<Encargado> NuevaListaEncargado = new List<Encargado>();
                return NuevaListaEncargado;
            }
            else
            {
                return Listaencargado;
            }
        }
        //Buscar 
        public List<Cliente>BuscarClientePorid(int id)
        {
            List<Cliente> NuevaListaCliente = new List<Cliente>();
            if(Listacliente == null)
            {
                return NuevaListaCliente;
            }
            else
            {
                var clienteObtenido = Listacliente.Find(X => id == X.id);
                NuevaListaCliente.Add(clienteObtenido);
                return NuevaListaCliente;
            }
        }

        public List<Persona> BuscarPersonaPordni(int dni)
        {
            List<Persona> NuevaListaPersona = new List<Persona>();
            if (Listapersona == null)
            {
                return NuevaListaPersona;
            }
            else
            {
                var personaObtenido = Listapersona.Find(X => dni == X.dni);
                NuevaListaPersona.Add(personaObtenido);
                return NuevaListaPersona;
            }
        }

        public List<Producto> BuscarProductoPorid(int id)
        {
            List<Producto> NuevaListaProducto = new List<Producto>();
            if (Listaproducto == null)
            {
                return NuevaListaProducto;
            }
            else
            {
                var productoObtenido = Listaproducto.Find(X => id == X.id);
                NuevaListaProducto.Add(productoObtenido);
                return NuevaListaProducto;
            }
        }

        public List<Turno> BuscarTurnoPorid(int id)
        {
            List<Turno> NuevaListaTurno = new List<Turno>();
            if (Listaturno == null)
            {
                return NuevaListaTurno;
            }
            else
            {
                var turnoObtenido = Listaturno.Find(X => id == X.id);
                NuevaListaTurno.Add(turnoObtenido);
                return NuevaListaTurno;
            }
        }

        public List<Stock> BuscarStockPorid(int id)
        {
            List<Stock> NuevaListaStock = new List<Stock>();
            if (Listastock == null)
            {
                return NuevaListaStock;
            }
            else
            {
                var stockObtenido = Listastock.Find(X => id == X.id);
                NuevaListaStock.Add(stockObtenido);
                return NuevaListaStock;
            }
        }

    }
}

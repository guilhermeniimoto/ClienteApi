using System.Collections.Generic;
using System.Web.Http;
using System.Linq;
using ClienteHostApi.Model;
using ClienteHostApi.DAL;



namespace ClienteHostApi.Controller
{
    public class ClientesController : ApiController
    {
        // GET api/clientehost 
        public IEnumerable<Cliente> Get() 
        {
            List<Cliente> _cliente = new List<Cliente>();
            ClientesDAL _clienteDal = new ClientesDAL();

            _cliente = _clienteDal.retornaClientes();

            return _cliente;

        }

        // GET api/clientehost/3
        public Cliente Get(int id)
        {
            List<Cliente> _cliente = new List<Cliente>();
            ClientesDAL _clienteDal = new ClientesDAL();
            _cliente = _clienteDal.retornaClientes();

            return _cliente.Where(x => x.Id == id).FirstOrDefault();


        }


    }

    
}

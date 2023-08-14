using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApiEmpresa.Models;

namespace WebApiEmpresa.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase {

        public List<Cliente> GetClientes() {
            List<Cliente> clientes = new List<Cliente>() {
                new Cliente() {Id=1, Nombre="Jorge", Apellido="Lorenzo", Ciudad="Ituzaingo", DNI="123"},
                new Cliente() {Id=2, Nombre="Agustin", Apellido="Romero", Ciudad="San Justo", DNI="456"},
                new Cliente() {Id=3, Nombre="Lionel", Apellido="Messi", Ciudad="Rosario", DNI="789"},
                new Cliente() {Id=4, Nombre="Emilio", Apellido="Martinez", Ciudad="Avellaneda", DNI="111"},

            };
            return clientes;
        }
        [HttpGet]
        public List<Cliente> GetClientesList() {
            return GetClientes();
        }

        [HttpGet("{id}")]
        public Cliente GetById(int id) {
            return GetClientes().Find(x => x.Id == id);
        }

        [HttpGet("ciudad/{ciudad}")]
        public Cliente GetByCiudad(string ciudad) {
            return GetClientes().Find(x => x.Ciudad.Equals(ciudad));
        }

    }
}

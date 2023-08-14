using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApiEmpresa.Models;

namespace WebApiEmpresa.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase {

        public List<Producto> GetProductos() {
            List<Producto> productos = new List<Producto>() {
                new Producto() {Id=1, Nombre="Pepsi", Precio=500.0, Categoria="Alimentos"},
                new Producto() {Id=2, Nombre="Oreo", Precio=600.0, Categoria="Alimentos"},
                new Producto() {Id=3, Nombre="Computadora",Precio=5000.0, Categoria="Tecnologia" },
                new Producto() {Id=4, Nombre="Mesa de escritorio",Precio=9000.0, Categoria="Muebles"},

            };
            return productos;
        }
        [HttpGet]
        public List<Producto> Get() {
            return GetProductos();
        }

        [HttpGet("{id}")]
        public Producto Get(int id) {
            return GetProductos().Find(x => x.Id == id);
        }
    }
}

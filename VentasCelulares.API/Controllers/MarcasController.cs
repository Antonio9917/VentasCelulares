using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VentasCelulares.API.Modelos;

namespace VentasCelulares.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarcasController : ControllerBase
    {


        [HttpGet]
        public IActionResult Get()
        {
            var marca = new List< Marcas>();

            marca.Add(new Marcas { idMarca = 1, Nombre = "Xiaomi", GrupoMarca = "Motorola" });
            marca.Add(new Marcas { idMarca = 2, Nombre = "Samsung", GrupoMarca = "Huawei" });



            return Ok(marca);
        }

        [HttpGet]
        [Route("{nombre}")]
        public IActionResult GetNombre(string nombre)
        {
            return Ok("El nomnbre de la marca es:" + nombre);
        }
    }
}

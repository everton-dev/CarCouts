using CarCouts.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace CarCouto.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarroController : ControllerBase
    {
        private readonly List<Carro> _carros;

        public CarroController()
        {
            _carros = new List<Carro>();
            CriarListaCarros();
        }

        [HttpGet("RecuperaCarros")]
        public IActionResult RecuperaCarros()
        {
            return Ok(_carros);
        }

        [HttpPost("AdicionaCarro")]
        public IActionResult AdicionaCarro(Carro carro)
        {
            _carros.Add(carro);

            return Ok(_carros);
        }

        private void CriarListaCarros()
        {
            if (_carros.Count > 0)
            {
                return;
            }

            _carros.Add(new Carro()
            {
                Id = Guid.NewGuid(),
                Marca = "BMW",
                Modelo = "320i",
                Ano = 2022,
                Cor = "Preto",
                EnderecoImagem = "https://www.razaoautomovel.com/wp-content/uploads/2016/02/1995-BMW-320i-Brand-New-1.jpg"
            });

            _carros.Add(new Carro()
            {
                Id = Guid.NewGuid(),
                Marca = "Audi",
                Modelo = "Q3",
                Ano = 2022,
                Cor = "Azul",
                EnderecoImagem = "https://cdn.motor1.com/images/mgl/10AAK/s3/audi-q3-45-tfsi-e-und-q3-sportback.jpg"
            });
        }
    }
}
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
                MarcaId = Guid.NewGuid(),
                Marca = new Marca() { Id = Guid.NewGuid(), Descricao = "BMW" },
                ModeloId = Guid.NewGuid(),
                Modelo = new Modelo() { Id = Guid.NewGuid(), Descricao = "320i", Marca = new Marca() { Id = Guid.NewGuid(), Descricao = "BMW" } },
                Ano = 2022,
                Cor = "Preto",
                EnderecoImagem = "https://www.razaoautomovel.com/wp-content/uploads/2016/02/1995-BMW-320i-Brand-New-1.jpg"
            });

            _carros.Add(new Carro()
            {
                Id = Guid.NewGuid(),
                MarcaId = Guid.NewGuid(),
                Marca = new Marca() { Id = Guid.NewGuid(), Descricao = "Audi" },
                ModeloId = Guid.NewGuid(),
                Modelo = new Modelo() { Id = Guid.NewGuid(), Descricao = "Q3", Marca = new Marca() { Id = Guid.NewGuid(), Descricao = "Audi" } },
                Ano = 2022,
                Cor = "Azul",
                EnderecoImagem = "https://cdn.motor1.com/images/mgl/10AAK/s3/audi-q3-45-tfsi-e-und-q3-sportback.jpg"
            });
        }

        [HttpGet("RecuperaMarcas")]
        public IActionResult RecuperaMarcas()
        {
            var marcas = new List<Marca>();

            marcas.Add(new Marca()
            {
                Id = Guid.NewGuid(),
                Descricao = "GM",
                Modelos = null
            });

            marcas.Add(new Marca()
            {
                Id = Guid.NewGuid(),
                Descricao = "Pegeot",
                Modelos = null
            });

            marcas.Add(new Marca()
            {
                Id = Guid.NewGuid(),
                Descricao = "Ferrari",
                Modelos = null
            });

            return Ok(marcas);
        }

        [HttpGet("RecuperaModelosPorMarca/{marca}")]
        public IActionResult RecuperaModelosPorMarca(string marca)
        {
            var modelos = new List<Modelo>();

            if (marca.ToLower() == "gm")
            {
                modelos.Add(new Modelo()
                {
                    Id = Guid.NewGuid(),
                    MarcaId = Guid.NewGuid(),
                    Marca = new Marca() { Id = Guid.NewGuid(), Descricao = "GM" },
                    Descricao = "Corsa",
                });

                modelos.Add(new Modelo()
                {
                    Id = Guid.NewGuid(),
                    MarcaId = Guid.NewGuid(),
                    Marca = new Marca() { Id = Guid.NewGuid(), Descricao = "GM" },
                    Descricao = "Onix",
                });
            }
            else if (marca.ToLower() == "pegeot")
            {
                modelos.Add(new Modelo()
                {
                    Id = Guid.NewGuid(),
                    MarcaId = Guid.NewGuid(),
                    Marca = new Marca() { Id = Guid.NewGuid(), Descricao = "Pegeot" },
                    Descricao = "307 SW",
                });

                modelos.Add(new Modelo()
                {
                    Id = Guid.NewGuid(),
                    MarcaId = Guid.NewGuid(),
                    Marca = new Marca() { Id = Guid.NewGuid(), Descricao = "Pegeot" },
                    Descricao = "206",
                });
            }
            else if (marca.ToLower() == "bmw")
            {
                modelos.Add(new Modelo()
                {
                    Id = Guid.NewGuid(),
                    MarcaId = Guid.NewGuid(),
                    Marca = new Marca() { Id = Guid.NewGuid(), Descricao = "BMW" },
                    Descricao = "Series 1",
                });

                modelos.Add(new Modelo()
                {
                    Id = Guid.NewGuid(),
                    MarcaId = Guid.NewGuid(),
                    Marca = new Marca() { Id = Guid.NewGuid(), Descricao = "BMW" },
                    Descricao = "Series 2",
                });
            }

            return Ok(modelos);
        }
    }
}
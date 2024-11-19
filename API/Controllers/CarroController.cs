using Core;
using Entidades;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarroController : ControllerBase
    {
        private readonly ICarroService _service;
        public CarroController(ICarroService service)
        {
            _service = service;
        }
        [HttpPost("adicionar-Caminhao")]
        public void AdicionaCaminhao(Carro carro)
        {
            Carro carroCreated = carro;
            _service.Adicionar(carroCreated);
        }
        [HttpGet("listar-Caminhao")]
        public List<Carro> ListarAluno()
        {
            return _service.Listar();
        }
        [HttpPut("editar-Caminhao")]
        public void EditarCaminhao(Carro carro)
        {
            _service.Editar(carro);
        }
        [HttpDelete("deletar-Caminhao")]
        public void DeletarCaminhao(int id)
        {
            _service.Remover(id);
        }

    }
}
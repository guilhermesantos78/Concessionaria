using Core;
using Entidades;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CaminhaoController : ControllerBase
    {
        private readonly ICaminhaoService _service;
        public CaminhaoController(ICaminhaoService service)
        {
            _service = service;
        }
        [HttpPost("adicionar-Caminhao")]
        public void AdicionaCaminhao(Caminhao caminhao)
        {
            Caminhao caminhaoCreated = caminhao;
            _service.Adicionar(caminhaoCreated);
        }
        public List<Caminhao> ListarAluno()
        {
            return _service.Listar();
        }
        [HttpPut("editar-Caminhao")]
        public void EditarCaminhao(Caminhao caminhao)
        {
            _service.Editar(caminhao);
        }
        [HttpDelete("deletar-Caminhao")]
        public void DeletarCaminhao(int id)
        {
            _service.Remover(id);
        }

        [HttpGet("get-informações-Caminhao")]
        public List<string> GetDetalhes()
        {
            List<Caminhao> listCaminhoes = _service.Listar();

            List<string> detalhesList = new List<string>();

            foreach (Caminhao c in listCaminhoes)
            {
                detalhesList.Add(c.ExibirDetalhes());
            }

            return detalhesList;
        }

    }
}

using Entidades;

namespace Core
{
    public class CaminhaoService : ICaminhaoService
    {
        public readonly ICaminhaoRepository repository;
        public CaminhaoService(ICaminhaoRepository caminhaoRepository)
        {
            repository = caminhaoRepository;
        }
        public void Adicionar(Caminhao caminhao)
        {
            repository.Adicionar(caminhao);
        }

        public void Remover(int id)
        {
            repository.Remover(id);
        }

        public List<Caminhao> Listar()
        {
            return repository.Listar();
        }
        public Caminhao BuscarPorId(int id)
        {
            return repository.BuscarPorId(id);
        }
        public void Editar(Caminhao editCaminhao)
        {
            repository.Editar(editCaminhao);
        }
    }
}


using Entidades;

namespace Core
{
    public class CarroService : ICarroService
    {
        public readonly ICarroRepository repository;
        public CarroService(ICarroRepository carroRepository)
        {
            repository = carroRepository;
        }
        public void Adicionar(Carro carro)
        {
            repository.Adicionar(carro);
        }

        public void Remover(int id)
        {
            repository.Remover(id);
        }

        public List<Carro> Listar()
        {
            return repository.Listar();
        }
        public Carro BuscarPorId(int id)
        {
            return repository.BuscarPorId(id);
        }
        public void Editar(Carro editCarro)
        {
            repository.Editar(editCarro);
        }
    }
}

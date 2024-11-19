
using Entidades;

namespace Core
{
    public interface ICarroService
    {
        void Adicionar(Carro carro);
        void Remover(int id);
        void Editar(Carro carro);
        List<Carro> Listar();
        Carro BuscarPorId(int id);
    }
}

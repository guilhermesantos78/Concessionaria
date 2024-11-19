
using Dapper.Contrib.Extensions;
using Entidades;
using Microsoft.Extensions.Configuration;
using System.Data.SQLite;

namespace Core
{
    public class CaminhaoRepository : ICaminhaoRepository
    {
        private readonly string ConnectionString;
        public CaminhaoRepository(IConfiguration config)
        {
            ConnectionString = config.GetConnectionString("DefaultConnection");
        }
        public void Adicionar(Caminhao caminhao)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<Caminhao>(caminhao);
        }
        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Caminhao caminhao = BuscarPorId(id);
            connection.Delete<Caminhao>(caminhao);
        }
        public void Editar(Caminhao caminhao)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<Caminhao>(caminhao);
        }
        public List<Caminhao> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Caminhao>().ToList();
        }
        public Caminhao BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Caminhao>(id);
        }
    }
}

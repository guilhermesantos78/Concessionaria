using Dapper;
using System.Data.SQLite;

namespace Core
{
    public static class InicializadorBd
    {
        private const string ConnectionString = "Data Source=Concessionaria.db";

        public static void Inicializar()
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string commandoSQLCaminhoes = @"   
                    CREATE TABLE IF NOT EXISTS Caminhoes(
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Modelo TEXT NOT NULL,
                        Ano INTEGER NOT NULL,
                        CapacidadeTanque REAL NOT NULL,
                        ConsumoPorKm REAL NOT NULL,
                        CapacidadeCarga REAL NOT NULL
                    );";

                string commandoSQLCarros = @"   
                    CREATE TABLE IF NOT EXISTS Carros(
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Modelo TEXT NOT NULL,
                        Ano INTEGER NOT NULL,
                        CapacidadeTanque REAL NOT NULL,
                        ConsumoPorKm REAL NOT NULL,
                        Tipo TEXT NOT NULL
                    );";

                connection.Execute(commandoSQLCaminhoes);
                connection.Execute(commandoSQLCarros);
            }
        }
    }
}

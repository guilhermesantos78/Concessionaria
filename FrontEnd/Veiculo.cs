
namespace FrontEnd
{
    public abstract class Veiculo : IVeiculo
    {
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public double CapacidadeTanque { get; set; }
        public double ConsumoPorKm { get; set; }

        public Veiculo(string modelo, int ano, double capacidadeTanque, double consumoPorKm)
        {
            Modelo = modelo;
            Ano = ano;
            CapacidadeTanque = capacidadeTanque;
            ConsumoPorKm = consumoPorKm;
        }

        public virtual void ExibirDetalhes()
        {
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Ano: {Ano}");
            Console.WriteLine($"Capacidade do Tanque: {CapacidadeTanque} litros");
            Console.WriteLine($"Consumo por Km: {ConsumoPorKm} km/l");
        }

        public virtual double CalcularConsumo(double distancia)
        {
            return distancia / ConsumoPorKm;
        }
    }

}

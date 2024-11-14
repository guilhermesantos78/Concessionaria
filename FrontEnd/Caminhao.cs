
namespace FrontEnd
{

    public class Caminhao : Veiculo
    {
        public double CapacidadeCarga { get; set; }

        public Caminhao(string modelo, int ano, double capacidadeTanque, double consumoPorKm, double capacidadeCarga)
            : base(modelo, ano, capacidadeTanque, consumoPorKm)
        {
            CapacidadeCarga = capacidadeCarga;
        }

        public override void ExibirDetalhes()
        {
            base.ExibirDetalhes();
            Console.WriteLine($"Capacidade de Carga: {CapacidadeCarga} toneladas");
        }

        public override double CalcularConsumo(double distancia)
        {
            double consumoFinal = base.CalcularConsumo(distancia);
            consumoFinal *= 1 + (CapacidadeCarga * 0.05);
            return consumoFinal;
        }
    }

}

using Dapper.Contrib.Extensions;
using System.Reflection;

namespace Entidades
{
    [Table("Caminhoes")]
    public class Caminhao : Veiculo
    {
        public double CapacidadeCarga { get; set; }

        public Caminhao(string modelo, int ano, double capacidadeTanque, double consumoPorKm, double capacidadeCarga, int id)
            : base(modelo, ano, capacidadeTanque, consumoPorKm, id)
        {
            CapacidadeCarga = capacidadeCarga;
        }
        public Caminhao()
        {

        }
        public override string ExibirDetalhes()
        {
            string mensagemDetalhes = base.ExibirDetalhes();
            mensagemDetalhes += $"Capacidade de Carga: {CapacidadeCarga} toneladas";

            return mensagemDetalhes;
        }

        public override double CalcularConsumo(double distancia)
        {
            double consumoFinal = base.CalcularConsumo(distancia);
            consumoFinal *= 1 + (CapacidadeCarga * 0.05);
            return consumoFinal;
        }
    }

}

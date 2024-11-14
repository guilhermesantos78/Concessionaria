
namespace FrontEnd
{
    public class Carro : Veiculo
    {
        public string Tipo { get; set; }

        public Carro(string modelo, int ano, double capacidadeTanque, double consumoPorKm, string tipo)
            : base(modelo, ano, capacidadeTanque, consumoPorKm)
        {
            Tipo = tipo;
        }

        public override void ExibirDetalhes()
        {
            base.ExibirDetalhes();
            Console.WriteLine($"Tipo: {Tipo}");
        }

        public override double CalcularConsumo(double distancia)
        {
            double consumoFinal = base.CalcularConsumo(distancia);
            if (Tipo == "Híbrido")
            {
                consumoFinal *= 0.8;

            }
            else if (Tipo == "Sedan")
            {
                consumoFinal *= 0.12;
            }
            return consumoFinal;
        }
    }

}

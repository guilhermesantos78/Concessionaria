using FrontEnd;

Carro carro1 = new Carro("Fusca 1969", 1969, 30, 10, "Sedan");
Caminhao caminhao1 = new Caminhao("Volvo FH16", 2020, 150, 4, 20);

List<IVeiculo> veiculos = new List<IVeiculo> { carro1, caminhao1 };

foreach (IVeiculo veiculo in veiculos)
{
    veiculo.ExibirDetalhes();
    double distancia = 100;
    double DistanciaPercorrida = veiculo.CalcularConsumo(distancia);
    Console.WriteLine($"Consumo para 100 km:{DistanciaPercorrida} litros\n");
}
using Entidades;

Veiculo carro1 = new Carro("Fusca 1969", 1969, 30, 10, "Sedan");
Veiculo carro2 = new Carro("Chevrolet Opala 1972", 1972, 60, 20, "Sedan");
Veiculo carro3 = new Carro("Ford Maverick 1974", 1974, 80, 15, "Coupe");
Veiculo carro4 = new Carro("VW Kombi 1975", 1975, 50, 12, "Van");
Veiculo carro5 = new Carro("Volvo C30", 2022, 70, 10, "Hibrido");
Veiculo carro6 = new Carro("Fiat Uno Mille 1990", 1990, 45, 14, "Hatchback");

Veiculo caminhao1 = new Caminhao("Volvo FH16", 2020, 150, 4, 20);
Veiculo caminhao2 = new Caminhao("Scania R450", 2018, 120, 6, 25);
Veiculo caminhao3 = new Caminhao("Mercedes-Benz Actros", 2019, 130, 5, 24);
Veiculo caminhao4 = new Caminhao("MAN TGX", 2021, 140, 4, 22);
Veiculo caminhao5 = new Caminhao("Iveco Stralis", 2017, 110, 8, 23);
Veiculo caminhao6 = new Caminhao("DAF XF105", 2016, 100, 7, 21);


List<IVeiculo> Veiculos = new List<IVeiculo> { carro1, carro2, carro3, carro4, carro5, carro6, caminhao1, caminhao2, caminhao3, caminhao4, caminhao5, caminhao6 };
foreach (IVeiculo Veiculo in Veiculos)
{
    Veiculo.ExibirDetalhes();
    double distancia = 100;
    double DistanciaPercorrida = Veiculo.CalcularConsumo(distancia);
    Console.WriteLine($"Distancia: {DistanciaPercorrida}");
    Console.WriteLine($"Consumo Estimado:{DistanciaPercorrida} litros\n");
}
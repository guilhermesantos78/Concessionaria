using FrontEnd;

Carro carro1 = new Carro("Fusca 1969", 1969, 30, 10, "Sedan"); 
Carro carro2 = new Carro("Chevrolet Opala 1972", 1972, 60, 20, "Sedan");
Carro carro3 = new Carro("Ford Maverick 1974", 1974, 80, 15, "Coupe");
Carro carro4 = new Carro("VW Kombi 1975", 1975, 50, 12, "Van");
Carro carro5 = new Carro("Chevrolet Monza 1986", 1986, 70, 18, "Sedan");
Carro carro6 = new Carro("Fiat Uno Mille 1990", 1990, 45, 14, "Hatchback");

Caminhao caminhao1 = new Caminhao("Volvo FH16", 2020, 150, 4, 20);
Caminhao caminhao2 = new Caminhao("Scania R450", 2018, 120, 6, 25);
Caminhao caminhao3 = new Caminhao("Mercedes-Benz Actros", 2019, 130, 5, 24);
Caminhao caminhao4 = new Caminhao("MAN TGX", 2021, 140, 4, 22);
Caminhao caminhao5 = new Caminhao("Iveco Stralis", 2017, 110, 8, 23);
Caminhao caminhao6 = new Caminhao("DAF XF105", 2016, 100, 7, 21);


List<IVeiculo> veiculos = new List<IVeiculo> { carro1, carro2, carro3, carro4, carro5, carro6, caminhao1, caminhao2, caminhao3, caminhao4, caminhao5, caminhao6 };

foreach (IVeiculo veiculo in veiculos)
{
    veiculo.ExibirDetalhes();
    double distancia = 100;
    double DistanciaPercorrida = veiculo.CalcularConsumo(distancia);
    Console.WriteLine($"Consumo para 100 km:{DistanciaPercorrida} litros\n");
}
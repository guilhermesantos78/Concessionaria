﻿using Dapper.Contrib.Extensions;

namespace Entidades
{
    [Table("Carros")]
    public class Carro : Veiculo
    {
        public string Tipo { get; set; }

        public Carro(string modelo, int ano, double capacidadeTanque, double consumoPorKm, string tipo, int id)
            : base(modelo, ano, capacidadeTanque, consumoPorKm, id)
        {
            Tipo = tipo;
        }

        public override string ExibirDetalhes()
        {
            string mensagemDetalhes = base.ExibirDetalhes();
            mensagemDetalhes += $"Tipo: {Tipo}";

            return mensagemDetalhes;
        }

        public override double CalcularConsumo(double distancia)
        {
            double consumoFinal = base.CalcularConsumo(distancia);

            switch (Tipo)
            {
                case "Híbrido":
                    consumoFinal *= 0.08;
                    break;
                case "Sedan":
                    consumoFinal *= 0.12;
                    break;
                case "Coupe":
                    consumoFinal *= 0.15;
                    break;
                case "Van":
                    consumoFinal *= 0.18;
                    break;
                case "Hatchback":
                    consumoFinal *= 0.14;
                    break;
                default:
                    consumoFinal *= 1;
                    break;
            }

            return consumoFinal;
        }

    }

}

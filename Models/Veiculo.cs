using System;
using System.Threading.Tasks;

namespace PTI_POO.Models
{
    public abstract class Veículo
    {
        protected double TaxaDiaria { get; set; }

        public abstract double CalcularValorTotal(int numDiarias);
    }

    public class Carro : Veículo
    {
        public Carro(double taxaDiaria)
        {
            TaxaDiaria = taxaDiaria;
        }

        public override double CalcularValorTotal(int numDiarias)
        {
            return numDiarias * TaxaDiaria;
        }
    }

    public class Moto : Veículo
    {
        public Moto(double taxaDiaria)
        {
            TaxaDiaria = taxaDiaria;
        }

        public override double CalcularValorTotal(int numDiarias)
        {
            return numDiarias * TaxaDiaria;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double taxaCarro = 50.0;
            double taxaMoto = 25.0;

            Carro carro = new Carro(taxaCarro);
            Moto moto = new Moto(taxaMoto);

            int numDiarias = 10;

            double valorTotalCarro = carro.CalcularValorTotal(numDiarias);
            double valorTotalMoto = moto.CalcularValorTotal(numDiarias);

            Console.WriteLine($"Valor total do carro: R${valorTotalCarro}");
            Console.WriteLine($"Valor total da moto: R${valorTotalMoto}");
        }
    }
}
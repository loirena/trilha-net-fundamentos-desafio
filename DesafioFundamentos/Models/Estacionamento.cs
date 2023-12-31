using System;
using System.Collections.Generic;
namespace DesafioFundamentos.Models

{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        private string placa = "";

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // *IMPLEMENTADO*
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            if (string.IsNullOrEmpty(placa)){ 
                Console.WriteLine("Não pode ser nulo");
                
            } else {
                 veiculos.Add(placa);
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            // *IMPLEMENTADO*
            
            if (veiculos.Contains(placa, StringComparer.OrdinalIgnoreCase))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                string inputHoras = Console.ReadLine(); 
                if (int.TryParse(inputHoras, out int horas))
                {
                    decimal valorTotal =  precoInicial + precoPorHora * horas; 
                    veiculos.Remove(placa);
                    Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                }
   
                // *IMPLEMENTADO*
                // *IMPLEMENTADO*
       
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            {
            if (veiculos.Count > 0)
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (string item in veiculos)
                {
                    Console.WriteLine($"Placa: {item}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
}
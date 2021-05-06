using System;
using System.Collections.Generic;

namespace DesafioDojo
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza pizzas = new Pizza();
            List<Sabores> PizzaSabor = new List<Sabores>(); 
            int quantidadePessoas = 0;
            string[] nome = new string[40];
            int[] notas = new int[6];
            string[] p = {"Marguerita", "4 queijos", "Escarola", "Portuguesa", "Frango + Catupiry", "Napolitana"};
            Console.Clear();
            Console.Write("Informe a quantidade de pessoas: ");
            quantidadePessoas = Int32.Parse(Console.ReadLine());
            for(int j = 0; j < quantidadePessoas; j++){
                
                Console.Write($"======= Informe o nome da pessoa {j+1} : ");
                nome[j] = Console.ReadLine();
                Console.WriteLine("Notas ===");
                Console.Write("Marguerita : ");
                notas[0] = Int32.Parse(Console.ReadLine());
                Console.Write("4 queijos : ");
                notas[1] = Int32.Parse(Console.ReadLine());
                Console.Write("Escarola : ");
                notas[2] = Int32.Parse(Console.ReadLine());
                Console.Write("Portuguesa : ");
                notas[3] = Int32.Parse(Console.ReadLine());
                Console.Write("Frango + Catupiry : ");
                notas[4] = Int32.Parse(Console.ReadLine());
                Console.Write("Napolitana : ");
                notas[5] = Int32.Parse(Console.ReadLine());
                for(int z = 0; z < 6; z++) {
                    pizzas.Sabor.Add(new Sabores{
                        Nome =  nome[j],
                        Nota = notas[z],
                        Sabor = p[z]
                    });
                }
            }
            pizzas.Sabor.ForEach(n => Console.WriteLine("Nome: "+n.Nome+", Sabor: " + n.Sabor +", Nota: " + n.Nota));
            
        }
    }
}

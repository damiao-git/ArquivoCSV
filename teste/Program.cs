using System;
using CadastroRelatorio.Entities;
using System.Collections.Generic;
using System.IO;

namespace CadastroRelatorio
    {
    class Program
        {
        static void Main(string[] args)
            {
            try
                {
                Console.Write("Quantos funcionarios quer cadastrar? ");
                int n = int.Parse(Console.ReadLine());
                List<Funcionario> fun = new List<Funcionario>();

                for (int i = 1; i <= n; i++)
                    {
                    Console.WriteLine($"Funcionario #{i}");
                    Console.Write("Qual o ID? ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Data de nascimento: ");
                    DateTime datanascimento = DateTime.Parse(Console.ReadLine());
                    Console.Write("Cargo: ");
                    string cargo = Console.ReadLine();
                    Console.Write("Salario: ");
                    double salario = double.Parse(Console.ReadLine());

                    fun.Add(new Funcionario(id, nome, datanascimento, cargo, salario));
                    }

                foreach (Funcionario f in fun)
                    {
                    Console.WriteLine(f);
                    }
                Console.WriteLine("Onde quer salvar essa lista de funcionarios?(Caminho c: ");
                string caminho = Console.ReadLine();

                using StreamWriter sw = File.AppendText(caminho);
                foreach (Funcionario f in fun)
                    {
                    sw.WriteLine(f.ToString());
                    }
                }
            catch (Exception e)
                {
                Console.WriteLine("Ocorreu um Erro: " + e.Message);
                }
            }
        }
    }

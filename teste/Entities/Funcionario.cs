using System;
using System.Globalization;

namespace CadastroRelatorio.Entities
    {
    class Funcionario
        {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cargo { get; set; }
        public double Salario { get; set; }

        public Funcionario()
            {
            }
        public Funcionario(int id, string nome, DateTime dataNascimento, string cargo, double salario)
            {
            Id = id;
            Nome = nome;
            DataNascimento = dataNascimento;
            Cargo = cargo;
            Salario = salario;
            }
        public void AumentarSalario(double porcentagem)
            {
            Salario += Salario * porcentagem / 100;
            }
        public override string ToString()
            {
            return $"{Id}, {Nome}, {DataNascimento.ToString("d")}, {Cargo}, {Salario.ToString("F2", CultureInfo.InvariantCulture)}";
            }

        }
    }

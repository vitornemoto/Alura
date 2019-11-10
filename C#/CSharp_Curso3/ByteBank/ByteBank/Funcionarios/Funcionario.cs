using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; } // utilizado protected para que as classes de herança possa utilizar, e as outra classe não.

        public static int TotalDeFuncionarios { get; private set; }

        public Funcionario(double salario, string cpf)
        {
            TotalDeFuncionarios++;
            Salario = salario;
            CPF = cpf;
            Console.WriteLine("Construtor de FUNCIONARIO");
        }
        public abstract double GetBonificacao();

        public abstract void AumentarSalario();
  
    }
}

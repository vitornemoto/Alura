using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    class Diretor:FuncionarioAutenticavel
    {
        public Diretor(string cpf):base(5000, cpf)
        {
            Console.WriteLine("Construtor de DIRETOR");
        }
        public override double GetBonificacao()
        {
            return Salario *= 1.5;
        }

        public override void AumentarSalario() 
        {
            Salario *= 1.15;
        }
    }
}

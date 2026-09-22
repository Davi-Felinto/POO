using System;
using System.Collections.Generic;
using System.Text;

namespace AppExercicio6POOAbstracao.Model
{
    public class Funcionario
    {
        public string nome;
        public int idade;
        public string sexo;
        public double salario;

        public double CalcularDecimoTerceiro(int mesesTrabalhados)
        {
            double decimoTerceiro = salario * mesesTrabalhados / 12;
            return decimoTerceiro;
        }
        public void CalcularFerias()
        {
            double ferias;
            ferias = salario + salario / 3;
            Console.WriteLine($"O valor das ferias do funcionario é R${Math.Round(ferias)}");
        }
    }
}

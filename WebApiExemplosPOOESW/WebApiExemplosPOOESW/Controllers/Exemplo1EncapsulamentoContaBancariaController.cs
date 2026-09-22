using Microsoft.AspNetCore.Mvc;
using WebApiExemplosPOOESW.Model;

namespace WebApiExemplosPOOESW.Controllers
{
    public class Exemplo1EncapsulamentoContaBancariaController : Controller
    {

        [HttpGet("RetornaDadosContaBancaria")]
        public string RetornaDadosContaBancaria(int numeroConta,
                                                string nomeTitular)
        {
            ContaBancaria contaBancaria = new ContaBancaria();
            contaBancaria.Numero = numeroConta;
            contaBancaria.Titular = nomeTitular;

            return contaBancaria.RetornarDadosClientes();
        }

        [HttpPost("Despositar")]
        public string Despositar(int numeroConta,
                                 string nomeTitular,
                                 double valorDeposito)
        {
            ContaBancaria contaBancaria = new ContaBancaria();
            contaBancaria.Numero = numeroConta;
            contaBancaria.Titular = nomeTitular;
            contaBancaria.Depositar(valorDeposito);

            return contaBancaria.RetornarDadosClientes();
        }

        [HttpPost("Sacar")]
        public string Sacar(int numeroConta,
                                 string nomeTitular,
                                 double valorSaque)
        {
            ContaBancaria contaBancaria = new ContaBancaria();
            contaBancaria.Numero = numeroConta;
            contaBancaria.Titular = nomeTitular;
            contaBancaria.Sacar(valorSaque);

            return contaBancaria.RetornarDadosClientes();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace AppExercicio5POOAbstracao.Model
{
    public class Locacao
    {
        public int idLocacao;
        public int idCarro;
        public int idCliente;
        public double valorCliente;
        public DateTime dataInicio;
        public DateTime dataFim;

        //Locacao (idLocacao, idCarro, idCliente, valorLocado, dataInicio, dataFim)
    }
}

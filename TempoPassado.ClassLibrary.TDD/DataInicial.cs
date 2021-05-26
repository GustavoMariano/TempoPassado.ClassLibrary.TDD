using System;

namespace TempoPassado.ClassLibrary.TDD
{
    public class DataInicial
    {
        public string ManipularData(DateTime data)
        {
            DateTime dataAgora = new DateTime(2021, 05, 26, 18, 00, 00);

            string tempoPassado = "";

            if (data > dataAgora)
                tempoPassado = "A data e hora inserida é futura, tente novamente!";
            else
            {
                ManipularData manipular = new ManipularData();
                tempoPassado += manipular.Verifica(data, dataAgora) + "atrás";                
            }

            return tempoPassado;
        }
    }
}

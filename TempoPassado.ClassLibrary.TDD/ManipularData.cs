using System;

namespace TempoPassado.ClassLibrary.TDD
{
    internal class ManipularData
    {
        ConverteDataParaString compara = new ConverteDataParaString();

        internal string Verifica(DateTime data, DateTime dataAgora)
        {
            ConverteDataParaString converteDataParaString = new ConverteDataParaString();

            string strDataPassada = "";
            int dias = dataAgora.Day - data.Day;
            int meses = dataAgora.Month - data.Month;
            int anos = dataAgora.Year - data.Year;
            int qtdSemanas = 0;
            bool semana = false, mes = false, ano = false;

            int horas = dataAgora.Hour - data.Hour;
            int minutos = dataAgora.Minute - data.Minute;
            int segundos = dataAgora.Second - data.Second;
            bool hora = false, minuto = false;

            if (anos > 0)
            {
                if (anos == 1)
                    strDataPassada += "um ano ";
                else
                    strDataPassada += converteDataParaString.DiasMesesAnosETempo(anos) + " anos ";
                ano = true;
            }

            if (meses > 0)
            {
                if (ano)
                    strDataPassada += "e ";
                if (meses == 1)
                    strDataPassada += "um mês ";
                else
                    strDataPassada += converteDataParaString.DiasMesesAnosETempo(meses) + " meses ";
                mes = true;
            }

            if (dias > 0)
            {
                int diasSemanas = 0;
                if (mes || ano)
                    strDataPassada += "e ";

                if (dias == 1)
                    return strDataPassada += "um dia ";
                else if (dias > 7)
                {
                    semana = true;

                    qtdSemanas = Convert.ToInt32(dias / 7);
                    diasSemanas = qtdSemanas * 7;
                    dias = dias - diasSemanas;

                    if (qtdSemanas == 1)
                        strDataPassada += converteDataParaString.Semanas(qtdSemanas) + " semana e ";
                    else
                    {
                        if (dias != 0)
                            strDataPassada += converteDataParaString.Semanas(qtdSemanas) + " semanas e ";
                        else
                            return strDataPassada += converteDataParaString.Semanas(qtdSemanas) + " semanas ";
                    }
                }
                if (semana)
                {
                    strDataPassada += converteDataParaString.DiasMesesAnosETempo(dias) + " dias ";
                }
                else
                    strDataPassada += converteDataParaString.DiasMesesAnosETempo(dias) + " dias ";
            }

            if (anos == 0 && meses == 0 && dias == 0)
            {
                if (horas > 0)
                {
                    if (horas == 1 || horas == 2)
                    {
                        switch (horas)
                        {
                            case 1: strDataPassada += converteDataParaString.Semanas(horas) + " hora "; break;
                            case 2: strDataPassada += converteDataParaString.Semanas(horas) + " horas "; break;
                            default: break;
                        }
                    }
                    else
                        strDataPassada += converteDataParaString.DiasMesesAnosETempo(horas);

                    hora = true;
                }
                if (minutos > 0 && minutos < 60)
                {
                    if (hora)
                        strDataPassada += "e ";
                    if(minutos < 21)


                    minuto = true;
                }

                if (segundos > 0 && minutos < 60)
                {
                    if (hora || minuto)
                        strDataPassada += "e ";
                }

            }
            return strDataPassada;
        }
    }
}
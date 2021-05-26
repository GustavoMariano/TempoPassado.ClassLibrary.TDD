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
            bool dia = false, semana = false, mes = false, ano = false, hora = false, minuto = false; ;            
                
            int horas = dataAgora.Hour - data.Hour;
            int minutos = Math.Abs(dataAgora.Minute - data.Minute);
            int segundos = Math.Abs(dataAgora.Second - data.Second);

            int auxSegundosDataAgora = dataAgora.Second;
            if ((auxSegundosDataAgora + data.Second) > 60 || (auxSegundosDataAgora + data.Second) == 0)
                minutos--;

            int auxMinutosDataAgora = dataAgora.Minute;
            if (auxMinutosDataAgora < data.Minute)
                horas--;

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
                        strDataPassada += converteDataParaString.SemanasHoras(qtdSemanas) + " semana e ";
                    else
                    {
                        if (dias != 0)
                            strDataPassada += converteDataParaString.SemanasHoras(qtdSemanas) + " semanas e ";
                        else
                            return strDataPassada += converteDataParaString.SemanasHoras(qtdSemanas) + " semanas ";
                    }
                }
                if (semana)
                {
                    strDataPassada += converteDataParaString.DiasMesesAnosETempo(dias) + " dias ";
                }
                else
                    strDataPassada += converteDataParaString.DiasMesesAnosETempo(dias) + " dias ";

                dia = true;
            }

            if (horas != 0 || minutos > 0 || segundos != 0)
            {
                if((ano || mes || dia) && (horas != 0 || minutos != 0 || segundos != 0))
                    strDataPassada += "e ";

                if (horas > 0)
                {
                    if (horas == 1 || horas == 2)
                    {
                        switch (horas)
                        {
                            case 1: strDataPassada += converteDataParaString.SemanasHoras(horas) + " hora "; break;
                            case 2: strDataPassada += converteDataParaString.SemanasHoras(horas) + " horas "; break;
                            default: break;
                        }
                    }
                    else if(horas > 19)
                        strDataPassada += converteDataParaString.MinutosESegundos(horas) + " hora ";
                    else
                        strDataPassada += converteDataParaString.DiasMesesAnosETempo(horas) + " horas ";

                    hora = true;
                }
                int segundosDoMinuto = 60 - segundos;
                if (minutos > 0 && minutos < 59)
                {
                    if (dataAgora.Second == 0 && data.Minute >59)
                        minutos++;

                    if ((data.Second + segundosDoMinuto) >= 60)
                        minutos++;

                    if (hora)
                        strDataPassada += "e ";

                    minutos = 60 - minutos;

                    if (minutos < 20)
                        strDataPassada += converteDataParaString.DiasMesesAnosETempo(minutos) + " minutos ";
                    else
                        strDataPassada += converteDataParaString.MinutosESegundos(minutos) + " minutos ";

                    minuto = true;
                }

                if (segundos > 0 && segundos < 59)
                {
                    if (hora || minuto)
                        strDataPassada += "e ";
                    
                    if (segundosDoMinuto < 20)
                        strDataPassada += converteDataParaString.DiasMesesAnosETempo(segundosDoMinuto) + " segundos ";
                    else
                        strDataPassada += converteDataParaString.MinutosESegundos(segundosDoMinuto) + " segundos ";
                }

            }
            return strDataPassada;
        }
    }
}
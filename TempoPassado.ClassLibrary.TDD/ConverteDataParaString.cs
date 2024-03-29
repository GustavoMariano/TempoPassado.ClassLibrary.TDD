﻿namespace TempoPassado.ClassLibrary.TDD

{
    internal class ConverteDataParaString
    {
        public string DiasMesesAnosETempo(int valor)
        {
            switch (valor)
            {
                case 1: return "um";
                case 2: return "dois";
                case 3: return "três";
                case 4: return "quatro";
                case 5: return "cinco";
                case 6: return "seis";
                case 7: return "sete";
                case 8: return "oito";
                case 9: return "nove";
                case 10: return "dez";
                case 11: return "onze";
                case 12: return "doze";
                case 13: return "treze";
                case 14: return "quatorze";
                case 15: return "quinze";
                case 16: return "dezesseis";
                case 17: return "dezessete";
                case 18: return "dezoito";
                case 19: return "dezenove";

                default: return "";
            }
        }

        public string SemanasHoras(int dia)
        {
            switch (dia)
            {
                case 1: return "uma";
                case 2: return "duas";
                case 3: return "três";
                case 4: return "quatro";
                    default: return "";
            }
        }

        public string MinutosESegundos(int valor)
        {
            string strRetornar = "";
            int unidadeHora = 0;

            if (valor == 20)
                strRetornar += "vinte";
            if (valor == 30)
                strRetornar += "trinta";
            if (valor == 40)
                strRetornar += "quarenta";
            if (valor == 50)
                strRetornar += "cinquenta";

            if (valor > 20 && valor < 30)
            {
                unidadeHora = valor - 20;
                if (valor == 1 || valor == 2)
                    strRetornar += "vinte e " + SemanasHoras(unidadeHora);
                else
                    strRetornar += "vinte e " + DiasMesesAnosETempo(unidadeHora);
            }

            if (valor > 30 && valor < 40)
            {
                unidadeHora = valor - 30;
                if (valor == 1 || valor == 2)
                    strRetornar += "trinta e " + SemanasHoras(unidadeHora);
                else
                    strRetornar += "trinta e " + DiasMesesAnosETempo(unidadeHora);
            }

            if (valor > 40 && valor < 50)
            {
                unidadeHora = valor - 40;
                if (valor == 1 || valor == 2)
                    strRetornar += "quarenta e " + SemanasHoras(unidadeHora);
                else
                    strRetornar += "quarenta e " + DiasMesesAnosETempo(unidadeHora);
            }

            if (valor > 50 && valor < 60)
            {
                unidadeHora = valor - 50;
                if (valor == 1 || valor == 2)
                    strRetornar += "cinquenta e " + SemanasHoras(unidadeHora);
                else
                    strRetornar += "cinquenta e " + DiasMesesAnosETempo(unidadeHora);
            }

            return strRetornar;
        }
    }
}
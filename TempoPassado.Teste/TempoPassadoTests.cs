using Microsoft.VisualStudio.TestTools.UnitTesting;
using TempoPassado.ClassLibrary.TDD;
using System;

namespace TempoPassado.Tests
{
    [TestClass]
    public class TempoPassadoTests
    {
        [TestMethod]
        public void DeveRetornarUmaHoraAtras() //Hora
        {
            DateTime data = new DateTime(2021, 05, 26, 17, 00, 00);
            DataInicial dataInicial = new DataInicial();

            Assert.AreEqual("uma hora atrás", dataInicial.ManipularData(data));
        }

        [TestMethod]
        public void DeveRetornarUmaHoraAtras() //HoraMinutos
        {
            DateTime data = new DateTime(2021, 05, 26, 17, 00, 00);
            DataInicial dataInicial = new DataInicial();

            Assert.AreEqual("uma hora atrás", dataInicial.ManipularData(data));
        }

        [TestMethod]
        public void DeveRetornarUmDiaAtras() //Dia
        {
            DateTime data = new DateTime(2021, 05, 25, 12, 00, 00);
            DataInicial dataInicial = new DataInicial();

            Assert.AreEqual("um dia atrás", dataInicial.ManipularData(data));
        }

        [TestMethod]
        public void DeveRetornarUmaSemanaEDoisDiasAtras() //SemanaDia
        {
            DateTime data = new DateTime(2021, 05, 17, 12, 00, 00);
            DataInicial dataInicial = new DataInicial();

            Assert.AreEqual("uma semana e dois dias atrás", dataInicial.ManipularData(data));
        }

        [TestMethod]
        public void DeveRetornarDoisMesesETresDiasAtras() //MesDia
        {
            DateTime data = new DateTime(2021, 03, 23, 12, 00, 00);
            DataInicial dataInicial = new DataInicial();

            Assert.AreEqual("dois meses e três dias atrás", dataInicial.ManipularData(data));
        }


        [TestMethod]
        public void DeveRetornarDuasSemanasAtras() //Semana
        {
            DateTime data = new DateTime(2021, 05, 12, 12, 00, 00);
            DataInicial dataInicial = new DataInicial();

            Assert.AreEqual("duas semanas atrás", dataInicial.ManipularData(data));
        }

        

        

        [TestMethod]
        public void DeveRetornarDoisAnosETresMesesEDoisDiaAtras()//AnosMesesDias
        {
            DateTime data = new DateTime(2019, 02, 24, 12, 00, 00);
            DataInicial dataInicial = new DataInicial();

            Assert.AreEqual("dois anos e três meses e dois dias atrás", dataInicial.ManipularData(data));
        }

        [TestMethod]
        public void DeveRetornarDoisAnosETresMesesEDuasSemanasEDoisDiaAtras()//AnosMesesSemanasDias
        {
            DateTime data = new DateTime(2019, 02, 10, 12, 00, 00);
            DataInicial dataInicial = new DataInicial();

            Assert.AreEqual("dois anos e três meses e duas semanas e dois dias atrás", dataInicial.ManipularData(data));
        }
    }
}

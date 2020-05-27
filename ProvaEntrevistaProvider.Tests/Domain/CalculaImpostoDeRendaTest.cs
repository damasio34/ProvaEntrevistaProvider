using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProvaEntrevistaProvider.Domain;
using ProvaEntrevistaProvider.Domain.Ineterfaces;

namespace ProvaEntrevistaProvider.Tests.Domain
{
    [TestClass]
    public class CalculaImpostoDeRendaTest
    {
        [TestMethod]
        public void Deve_retornar_sucesso_quando_imposto_de_renda_de_pessoa_fisica_eh_calculado_corretamente()
        {
            ICalculoImpostoDeRenda calculoImpostoDeRenda = new ImpostoDeRendaPessoaFisica();
            decimal impostoDeRenda = calculoImpostoDeRenda.Calcular(10000M);
            Assert.AreEqual(2750, impostoDeRenda);
        }

        [TestMethod]
        public void Deve_retornar_sucesso_quando_imposto_de_renda_de_pessoa_juridica_eh_calculado_corretamente()
        {
            ICalculoImpostoDeRenda calculoImpostoDeRenda = new ImpostoDeRendaPessoaJuridica();
            decimal impostoDeRenda = calculoImpostoDeRenda.Calcular(10000M);
            Assert.AreEqual(2250, impostoDeRenda);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Services;

namespace WindowsFormsApp1.Tests

{
    [TestClass]
    public class ValidaContaTests
    {
        private ValidaConta _validador;

        [TestInitialize]
        public void Setup()
        {
            _validador = new ValidaConta();
        }

        [TestMethod]
        public void ValidarContaPagar_ValorPositivoDataFutura_DevePassar()
        {
            // Arrange
            var contaPagar = new ContaPagar
            {
                Conta = "Fornecedor A",
                Valor = 1000,
                DataVenc = DateTime.Now.AddDays(10)
            };

            // Act & Assert
            try
            {
                _validador.ValidarConta(contaPagar);
                Assert.IsTrue(true); // Se não lançar exceção, o teste passa
            }
            catch (Exception)
            {
                Assert.Fail("A validação deveria ter passado.");
            }
        }

        [TestMethod]
        public void ValidarContaPagar_ValorZero_DeveLancarExcecao()
        {
            // Arrange
            var contaPagar = new ContaPagar
            {
                Conta = "Fornecedor B",
                Valor = 0,
                DataVenc = DateTime.Now.AddDays(10)
            };

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => _validador.ValidarConta(contaPagar));
        }

        [TestMethod]
        public void ValidarContaPagar_DataVencimentoNoPassado_DeveLancarExcecao()
        {
            // Arrange
            var contaPagar = new ContaPagar
            {
                Conta = "Fornecedor C",
                Valor = 1000,
                DataVenc = DateTime.Now.AddDays(-10)
            };

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => _validador.ValidarConta(contaPagar));
        }

        [TestMethod]
        public void ValidarContaReceber_ValorPositivoDataFutura_DevePassar()
        {
            // Arrange
            var contaReceber = new ContaReceber
            {
                Conta = "Cliente A",
                Valor = 1500,
                DataVenc = DateTime.Now.AddDays(5)
            };

            // Act & Assert
            try
            {
                _validador.ValidarConta(contaReceber);
                Assert.IsTrue(true); // Se não lançar exceção, o teste passa
            }
            catch (Exception)
            {
                Assert.Fail("A validação deveria ter passado.");
            }
        }

        [TestMethod]
        public void ValidarContaReceber_ValorNegativo_DeveLancarExcecao()
        {
            // Arrange
            var contaReceber = new ContaReceber
            {
                Conta = "Cliente B",
                Valor = -500,
                DataVenc = DateTime.Now.AddDays(5)
            };

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => _validador.ValidarConta(contaReceber));
        }

        [TestMethod]
        public void ValidarContaReceber_DataVencimentoNoPassado_DeveLancarExcecao()
        {
            // Arrange
            var contaReceber = new ContaReceber
            {
                Conta = "Cliente C",
                Valor = 1500,
                DataVenc = DateTime.Now.AddDays(-5)
            };

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => _validador.ValidarConta(contaReceber));
        }
    }
}



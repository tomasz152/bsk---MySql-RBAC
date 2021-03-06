using System.Collections.Generic;
// <copyright file="RBACowyConnectorTest.cs">Copyright ©  2017</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using bsk___proba_2;

namespace bsk___proba_2.Tests
{
    /// <summary>Ta klasa zawiera sparametryzowane testy jednostek dla RBACowyConnector</summary>
    [PexClass(typeof(RBACowyConnector))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class RBACowyConnectorTest
    {
        [TestMethod]
        public void TestInicjacji()
        {
            try
            {
                RBACowyConnector.Inicjalizuj("localhost", "tomasz152", "bombelek", "15000");
            }
            catch (Exception ex)
            {
                Assert.Fail("Coś się zjebało. Błąd: " + ex.Message);
            }
        }

        /// <summary>Zastępcza klasa testowa dla Insert(String, List`1&lt;KeyValuePair`2&lt;String,String&gt;&gt;, Boolean)</summary>
        [PexMethod]
        public void InsertTest(
            string tabela,
            List<KeyValuePair<string, string>> kolAtr,
            bool nieIstnieją
        )
        {
            RBACowyConnector.Insert(tabela, kolAtr, nieIstnieją);
            // TODO: dodaj asercje do metoda RBACowyConnectorTest.InsertTest(String, List`1<KeyValuePair`2<String,String>>, Boolean)
        }
    }
}

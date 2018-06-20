using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Validateur.Class.Nombre;

namespace Extension.Validateur.Test.Type.Nombre
{
    [TestClass]
    public class Decimal
    {
        private decimal testDecimal;
        private decimal valeurMaximum;
        private decimal valeurMinimum;

        [TestInitialize]
        public void Initialiser()
        {
            testDecimal = 5;
            valeurMaximum = 10;
            valeurMinimum = 0;
        }

        [TestMethod]
        public void Entre_ParamOk_Ok()
        {
            testDecimal.Entre(valeurMaximum, valeurMinimum, nameof(testDecimal));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Entre_DecimalEnDessous_LeveException()
        {
            valeurMinimum = 6;
            testDecimal.Entre(valeurMaximum, valeurMinimum, nameof(testDecimal));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Entre_DecimalAuDessus_LeveException()
        {
            valeurMaximum = 4;
            testDecimal.Entre(valeurMaximum, valeurMinimum, nameof(testDecimal));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Inferieur_LeveException()
        {
            valeurMaximum = 4;
            testDecimal.Inferieur(valeurMinimum, nameof(testDecimal));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Positi_LeveException()
        {
            testDecimal = -1;
            testDecimal.Positif(nameof(testDecimal));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void StrictementPositif_LeveException()
        {
            testDecimal = 0;
            testDecimal.StrictementPositif(nameof(testDecimal));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Superieur_LeveException()
        {
            valeurMinimum = 10;
            testDecimal.Superieur(valeurMinimum, nameof(testDecimal));
        }
    }
}

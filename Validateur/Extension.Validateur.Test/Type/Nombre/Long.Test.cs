using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validateur.Type.Nombre;

namespace Extension.Validateur.Test.Type.Nombre
{
    [TestClass]
    public class Long
    {
        private long testLong;
        private long valeurMaximum;
        private long valeurMinimum;

        [TestInitialize]
        public void Initialiser()
        {
            testLong = 5;
            valeurMaximum = 10;
            valeurMinimum = 0;
        }

        [TestMethod]
        public void Entre_ParamOk_Ok()
        {
            testLong.Entre(valeurMaximum, valeurMinimum, nameof(testLong));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Entre_LongEnDessous_LeveException()
        {
            valeurMinimum = 6;
            testLong.Entre(valeurMaximum, valeurMinimum, nameof(testLong));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Entre_LongAuDessus_LeveException()
        {
            valeurMaximum = 4;
            testLong.Entre(valeurMaximum, valeurMinimum, nameof(testLong));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Inferieur_LeveException()
        {
            valeurMaximum = 4;
            testLong.Inferieur(valeurMinimum, nameof(testLong));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Positi_LeveException()
        {
            testLong = -1;
            testLong.Positif(nameof(testLong));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void StrictementPositif_LeveException()
        {
            testLong = 0;
            testLong.StrictementPositif(nameof(testLong));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Superieur_LeveException()
        {
            valeurMinimum = 10;
            testLong.Superieur(valeurMinimum, nameof(testLong));
        }
    }
}

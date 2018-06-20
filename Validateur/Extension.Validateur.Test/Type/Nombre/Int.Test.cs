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
    public class Int
    {
        private int testInt;
        private int valeurMaximum;
        private int valeurMinimum;

        [TestInitialize]
        public void Initialiser()
        {
            testInt = 5;
            valeurMaximum = 10;
            valeurMinimum = 0;
        }

        [TestMethod]
        public void Entre_ParamOk_Ok()
        {
            testInt.Entre(valeurMaximum, valeurMinimum, nameof(testInt));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Entre_IntEnDessous_LeveException()
        {
            valeurMinimum = 6;
            testInt.Entre(valeurMaximum, valeurMinimum, nameof(testInt));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Entre_IntAuDessus_LeveException()
        {
            valeurMaximum = 4;
            testInt.Entre(valeurMaximum, valeurMinimum, nameof(testInt));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Inferieur_LeveException()
        {
            valeurMaximum = 4;
            testInt.Inferieur( valeurMinimum, nameof(testInt));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Positi_LeveException()
        {
            testInt = -1;
            testInt.Positif(nameof(testInt));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void StrictementPositif_LeveException()
        {
            testInt = 0;
            testInt.StrictementPositif(nameof(testInt));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Superieur_LeveException()
        {
            valeurMinimum = 10;
            testInt.Superieur(valeurMinimum, nameof(testInt));
        }
    }
}

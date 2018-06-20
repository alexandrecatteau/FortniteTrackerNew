using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validateur.Type;

namespace Extension.Validateur.Test.Type
{
    [TestClass]
    public class String
    {
        private string stringTest;
        private int valeurMaximum;
        private int valeurMinimum;

        [TestInitialize]
        public void Initialiser()
        {
            stringTest = "Test";
            valeurMaximum = 10;
            valeurMinimum = 1;
        }

        [TestMethod]
        public void Obligatoire_ParametreOk_Ok()
        {
            stringTest.Obligatoire(nameof(stringTest));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Obligatoire_StringNull_LeveException()
        {
            stringTest = null;
            stringTest.Obligatoire(nameof(stringTest));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Obligatoire_StringVide_LeveException()
        {
            stringTest = " ";
            stringTest.Obligatoire(nameof(stringTest));
        }

        [TestMethod]
        public void CaractereMaximum_ParamOk_Ok()
        {
            stringTest.CaractereMaximum(valeurMaximum, nameof(stringTest));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CaractereMaximum_StringNull_LeveExeption()
        {
            stringTest = null;
            stringTest.CaractereMaximum(valeurMaximum, nameof(stringTest));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CaractereMaximum_StringSuperieur_LeveExeption()
        {
            valeurMaximum = 1;
            stringTest.CaractereMaximum(valeurMaximum, nameof(stringTest));
        }

        [TestMethod]
        public void CaractereMinimum_ParamOk_Ok()
        {
            stringTest.CaractereMinimum(valeurMinimum, nameof(stringTest));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CaractereMinimum_StringNull_LeveExeption()
        {
            stringTest = null;
            stringTest.CaractereMinimum(valeurMinimum, nameof(stringTest));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CaractereMinimum_StringSuperieur_LeveExeption()
        {
            valeurMinimum = 100;
            stringTest.CaractereMinimum(valeurMinimum, nameof(stringTest));
        }
    }
}

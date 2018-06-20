using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Validateur.Type;

namespace Extension.Validateur.Test.Type
{
    [TestClass]
    public class Objet
    {
        [TestMethod]
        public void NonNull_ValeurNonNull_Ok()
        {
            string stringTest = "Test";
            stringTest.NonNull(nameof(stringTest));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NonNull_ValeurNull_LeveException()
        {
            string stringTest = null;
            stringTest.NonNull(nameof(stringTest));
        }
    }
}

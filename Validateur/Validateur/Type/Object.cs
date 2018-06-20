using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validateur.Type
{
    /// <summary>
    /// Validation des objets.
    /// </summary>
    public static class Object
    {
        /// <summary>
        /// Lance une exception si le l'objet est null.
        /// </summary>
        /// <param name="nomParametre">Nom du paramètre.</param>
        public static void NonNull<T>(this T t, string nomParametre)
        {
            if(t == null)
            {
                throw new ArgumentNullException($"Le paramètre {nomParametre} est null.");
            }
        }
    }
}
